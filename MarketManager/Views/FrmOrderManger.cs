using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketManager.Interface;
using MarketManager.Models;
using System.Windows.Forms;
using MarketManager.Enum;
using MarketManager.ExtendsionMethod;

namespace MarketManager.Views
{
    public partial class FrmOrderManger : Form
    {
        private Dictionary<string, object> dataSender;
        private FrmOrderDetailManager detailForm;
        private ISellable sellBuss;
        private List<SP_GET_Order_Result> orders;
        private int currentId;
        private List<Customer> customers;
        private List<SP_GET_PRODUCT_Result> products;
        private BindingSource orderSource;

        public FrmOrderManger(Dictionary<string, object> dataSender, FrmOrderDetailManager manager, ISellable sellBuss)
        {
            this.dataSender = dataSender;
            this.detailForm = manager;
            this.sellBuss = sellBuss;
            InitializeComponent();
        }

        private void FrmOrderManger_Load(object sender, EventArgs e)
        {
            
            orders = sellBuss.GetOrders();
            orderSource = new BindingSource();
            orderSource.DataSource = orders;

            //currentId = sellBuss.GetCurrentOrderIndex();

            products = sellBuss.GetProducts();
            dataSender.SetData("products", sellBuss.AddIDToName(products));

            customers = sellBuss.GetCustomers();
            dataSender.SetData("customers", customers);

            currentId = sellBuss.GetCurrentOrderIndex();
            dvgOrder.DataSource = orderSource;
            dvgOrder.Columns["custom_id"].Visible = false;
            dvgOrder.Columns["staff_id"].Visible = false;
            dvgOrder.AllowUserToAddRows = false;

            dataSender.SetData("staff", new Staff() { staff_id = 1, staff_name = "Giang Sơn Bá" });

            detailForm.VisibleChanged += Frm_Detail_Visible_Change;

            
        }

        //when click Add, sub-form display
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataSender.SetData("fnState", CRUDState.Add);
            dataSender.SetData("currentId", currentId+1);
            dataSender.SetData("staffId", 1);
            
            detailForm.Show();
        }

        //when double click on row, sub-form display, user can read, update, delete
        private void dvgOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataSender.SetData("fnState", CRUDState.RUD);
            SP_GET_Order_Result order = (SP_GET_Order_Result)orderSource[e.RowIndex];
            dataSender.SetData("orderId", order.order_id);
            dataSender.SetData("customId", order.custom_id);
            dataSender.SetData("staffId", order.staff_id);
            dataSender.SetData("mark", order.used_mark);
            dataSender.SetData("rowIndex", e.RowIndex);
            detailForm.Show();
        }

        //when sub form display, father disable, then subform hide, father display and received data
        // after recceived data, father handled bussiness base on function state
        private void Frm_Detail_Visible_Change(object sender, EventArgs e)
        {
            if (detailForm.Visible)
            {
                dataSender.SetData("dataState", false);
                this.Enabled = false;
                return;
            }

            this.Enabled = true;

            //recceived data
            customers = (List<Customer>)dataSender["customers"];
            products = (List<SP_GET_PRODUCT_Result>)dataSender["products"];

            //add mode
            if ((CRUDState)dataSender["fnState"] == CRUDState.Add)
                HandlerAdd();
            else
                HandlerUpdate();

        }

       
        private SP_GET_Order_Result ConvertOrder(Order order)
        {
            return new SP_GET_Order_Result()
            {
                order_id = order.order_id,
                staff_id = order.staff_id,
                custom_id = order.customer_id,
                used_mark = order.used_mark,
                paid_price = order.paid_price,
                pay_day = DateTime.Now,
                name = customers[customers.FindIndex(x => x.custom_id == order.customer_id)].name.Substring(3),
                staff_name = ((Staff)dataSender["staff"]).staff_name
            };
        }

        private void HandlerAdd()
        {
            if (!(bool)dataSender["dataState"])
                return;
            Order order = new Order();
            order.order_id = (int)dataSender["currentId"];
            order.customer_id = (int?)dataSender["customId"];
            order.staff_id = (int?)dataSender["staffId"];
            order.used_mark = (short)dataSender["mark"];
            List<OrderDetail> details = (List<OrderDetail>)dataSender["orderDetails"];
            sellBuss.CheckOut(order, details);
            if (sellBuss.AddOrder(order))
            {
                orderSource.Add(ConvertOrder(order));
                if (sellBuss.AddOrderDetails(details))
                {
                    MessageBox.Show("thêm thành công");
                }
                else
                    MessageBox.Show("thêm thất bại");
                return;
            }
            MessageBox.Show("thêm thất bại");

        }

        private void HandlerUpdate()
        {
            bool dataSate = (bool)dataSender["dataState"];
            if (!dataSate)
                return;
            Order order = new Order();
            order.order_id = (int)dataSender["orderId"];
            order.staff_id = (int)dataSender["staffId"];
            order.customer_id = (int)dataSender["customId"];
            order.used_mark = (short)dataSender["mark"];
            List<OrderDetail> details = (List<OrderDetail>)dataSender["orderDetails"];
            sellBuss.CheckOut(order, details);
            if (sellBuss.UpdateOrder(order))
            {
                
                if (sellBuss.UpdateOrderDetails(details))
                {
                    orderSource[(int)dataSender["rowIndex"]] = ConvertOrder(order);
                    ReLoadGridView();
                    MessageBox.Show("update thành công");
                    return;
                }
                MessageBox.Show("Update chi tiết thất bại");
                return;
            }
            MessageBox.Show("Update thất bại");
        }

        private void ReLoadGridView()
        {
            dvgOrder.Update();
            dvgOrder.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cell = dvgOrder.SelectedRows[0].Cells;
            
            if (sellBuss.DeleteOrder(new Order() { order_id = (int)cell[0].Value }))
            {
                orderSource.RemoveAt(cell[0].RowIndex);
                MessageBox.Show("Xoá đơn hàng thành công");
                return;
            }
            MessageBox.Show("xoá đơn hàng không thành công");
        }
    }
}
