using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketManager.Models;
using MarketManager.Interface;
using MarketManager.Enum;
using MarketManager.ExtendsionMethod;
namespace MarketManager.Views
{
    public partial class FrmOrderDetailManager : Form
    {
        private Dictionary<string, object> dataSender;
        private ISellable sellBuss;
        private int orderId, staffId, customId;
        private BindingSource bindingSource;
        private List<Customer> customers; 
        private List<SP_GET_PRODUCT_Result> products;

        public FrmOrderDetailManager(Dictionary<string, object> dataSender, ISellable sellBuss)
        {
            this.sellBuss = sellBuss;
            this.dataSender = dataSender;
            InitializeComponent();
        }

        private void FrmOrderDetailManager_Load(object sender, EventArgs e)
        {

            dvgDetail.AllowUserToAddRows = false;
            

            products = (List<SP_GET_PRODUCT_Result>)dataSender["products"];
            customers = (List<Customer>)dataSender["customers"];

            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "name";
            cbCustomer.ValueMember = "custom_id";

            cbProduct.DataSource = products;
            cbProduct.DisplayMember = "product_name";
            cbProduct.ValueMember = "product_id";

            dataSender.SetData("dataState", false);
            
        }

        private void FrmOrderDetailManager_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if((CRUDState)dataSender["fnState"] == CRUDState.Add)
                {
                    orderId = (int)dataSender["currentId"];
                    staffId = (int)dataSender["staffId"];
                    Display(-1);
                }
                else
                {
                    orderId = (int)dataSender["orderId"];
                    edtMark.Text = dataSender["mark"].ToString();
                    customId = (int)dataSender["customId"];
                    staffId = (int)dataSender["staffId"];
                    Display(orderId);
                }
            }
            else
            {
                dataSender.SetData("orderDetails", bindingSource.Cast<OrderDetail>().ToList());
                dataSender.SetData("customId", ((Customer)cbCustomer.SelectedItem).custom_id);
                dataSender.SetData("mark", short.Parse(edtMark.Text==""?"0":edtMark.Text));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataSender.SetData("dataState", true);

            OrderDetailResult detail = GetDataFromView();

            if (sellBuss.CheckQuantity(products[products.FindIndex(x=>x.product_id == detail.product_id)], detail))
            {
                bindingSource.Add(detail);
                RefreshGridView();
                return;
            }
            MessageBox.Show("số lượng tồn kho không đủ");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataSender.SetData("dataState", true);
            int index = dvgDetail.SelectedRows[0].Index;
            OrderDetailResult orderDetail = GetDataFromView();
            OrderDetailResult old = (OrderDetailResult)bindingSource[index];
            products[products.FindIndex(x => x.product_id == old.product_id)].quantity -= (short)(orderDetail.quantity - old.quantity);
            bindingSource[index] = orderDetail;
            RefreshGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataSender.SetData("dataState", true);
            bindingSource.RemoveAt(dvgDetail.SelectedRows[0].Index);
            RefreshGridView();
        }


        public void ConfigView()
        {
            dvgDetail.Columns["order_id"].Visible = false;
            dvgDetail.Columns["Order"].Visible = false;
            dvgDetail.Columns["Product"].Visible = false;
            
        }

        private void RefreshGridView()
        {
            dvgDetail.Update();
            dvgDetail.Refresh();
        }

        private void Display(int orderId)
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = sellBuss.GetDetailResults(orderId, products);
            dvgDetail.DataSource = bindingSource;
            ConfigView();
        }


        private void dvgDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           cbProduct.Text = dvgDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
           edtAmount.Text = dvgDetail.Rows[e.RowIndex].Cells[3].Value.ToString();
           edtDiscount.Text = dvgDetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private OrderDetailResult GetDataFromView()
        {
            OrderDetailResult detail = new OrderDetailResult();
            dynamic selected = cbProduct.SelectedItem;
            detail.order_id = orderId;
            detail.product_id = selected.product_id;
            detail.discount = double.Parse(edtDiscount.Text==""?"0":edtDiscount.Text);
            detail.quantity = edtAmount.Text == "" ? (short)1 : short.Parse(edtAmount.Text);
            detail.price = selected.price*detail.quantity - selected.price*detail.quantity*detail.discount/100;
            detail.product_name = selected.product_name;
            return detail;
        }

        private void FrmOrderDetailManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        
    }
}
