﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketManager.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class MarketEntities : DbContext
    {
        public MarketEntities()
            : base("name=MarketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<view_brand_detail> view_brand_detail { get; set; }
        public DbSet<view_category_detail> view_category_detail { get; set; }
        public DbSet<view_order> view_order { get; set; }
        public DbSet<view_product> view_product { get; set; }
        public DbSet<view_product_detail> view_product_detail { get; set; }
    
        [EdmFunction("MarketEntities", "GetDataBaseInfo")]
        public virtual IQueryable<GetDataBaseInfo_Result> GetDataBaseInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetDataBaseInfo_Result>("[MarketEntities].[GetDataBaseInfo]()");
        }
    
        [EdmFunction("MarketEntities", "GetPanigationProducts")]
        public virtual IQueryable<GetPanigationProducts_Result> GetPanigationProducts(Nullable<int> start, Nullable<int> size)
        {
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(int));
    
            var sizeParameter = size.HasValue ?
                new ObjectParameter("size", size) :
                new ObjectParameter("size", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetPanigationProducts_Result>("[MarketEntities].[GetPanigationProducts](@start, @size)", startParameter, sizeParameter);
        }
    
        [EdmFunction("MarketEntities", "GetTopSellingProduct")]
        public virtual IQueryable<GetTopSellingProduct_Result> GetTopSellingProduct(Nullable<short> quantity)
        {
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetTopSellingProduct_Result>("[MarketEntities].[GetTopSellingProduct](@quantity)", quantityParameter);
        }
    
        public virtual int SP_ADD_Order(Nullable<int> customer_id, Nullable<int> staff_id, Nullable<short> usedmark, Nullable<double> paid_price)
        {
            var customer_idParameter = customer_id.HasValue ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(int));
    
            var staff_idParameter = staff_id.HasValue ?
                new ObjectParameter("staff_id", staff_id) :
                new ObjectParameter("staff_id", typeof(int));
    
            var usedmarkParameter = usedmark.HasValue ?
                new ObjectParameter("usedmark", usedmark) :
                new ObjectParameter("usedmark", typeof(short));
    
            var paid_priceParameter = paid_price.HasValue ?
                new ObjectParameter("paid_price", paid_price) :
                new ObjectParameter("paid_price", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ADD_Order", customer_idParameter, staff_idParameter, usedmarkParameter, paid_priceParameter);
        }
    
        public virtual int SP_ADD_OrderDetail(Nullable<int> order_id, Nullable<int> product_id, Nullable<short> quantity, Nullable<double> discount)
        {
            var order_idParameter = order_id.HasValue ?
                new ObjectParameter("order_id", order_id) :
                new ObjectParameter("order_id", typeof(int));
    
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(short));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("discount", discount) :
                new ObjectParameter("discount", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ADD_OrderDetail", order_idParameter, product_idParameter, quantityParameter, discountParameter);
        }
    
        public virtual int SP_ADD_Product(string productName, Nullable<int> brandId, Nullable<int> categoryId, Nullable<double> price, Nullable<short> quantity)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var brandIdParameter = brandId.HasValue ?
                new ObjectParameter("brandId", brandId) :
                new ObjectParameter("brandId", typeof(int));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ADD_Product", productNameParameter, brandIdParameter, categoryIdParameter, priceParameter, quantityParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int SP_Analyst_Product()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Analyst_Product");
        }
    
        public virtual ObjectResult<SP_Analyst_Product_Saled_Result> SP_Analyst_Product_Saled()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Analyst_Product_Saled_Result>("SP_Analyst_Product_Saled");
        }
    
        public virtual ObjectResult<SP_Analyst_Profit_Result> SP_Analyst_Profit()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Analyst_Profit_Result>("SP_Analyst_Profit");
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int SP_DELETE_Order(Nullable<int> orderid)
        {
            var orderidParameter = orderid.HasValue ?
                new ObjectParameter("orderid", orderid) :
                new ObjectParameter("orderid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_Order", orderidParameter);
        }
    
        public virtual int SP_DELETE_Product(Nullable<int> product_id)
        {
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_Product", product_idParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<SP_GET_Customer_Result> SP_GET_Customer(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_Customer_Result>("SP_GET_Customer", nameParameter);
        }
    
        public virtual ObjectResult<SP_GET_Order_Result> SP_GET_Order(string date)
        {
            var dateParameter = date != null ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_Order_Result>("SP_GET_Order", dateParameter);
        }
    
        public virtual ObjectResult<SP_GET_PRODUCT_Result> SP_GET_PRODUCT(Nullable<int> catid, Nullable<int> brandId)
        {
            var catidParameter = catid.HasValue ?
                new ObjectParameter("catid", catid) :
                new ObjectParameter("catid", typeof(int));
    
            var brandIdParameter = brandId.HasValue ?
                new ObjectParameter("brandId", brandId) :
                new ObjectParameter("brandId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_PRODUCT_Result>("SP_GET_PRODUCT", catidParameter, brandIdParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int SP_UPDATE_Order(Nullable<int> order_id, Nullable<int> customer_id, Nullable<int> staff_id, Nullable<double> paid_price, Nullable<short> used_mark)
        {
            var order_idParameter = order_id.HasValue ?
                new ObjectParameter("order_id", order_id) :
                new ObjectParameter("order_id", typeof(int));
    
            var customer_idParameter = customer_id.HasValue ?
                new ObjectParameter("customer_id", customer_id) :
                new ObjectParameter("customer_id", typeof(int));
    
            var staff_idParameter = staff_id.HasValue ?
                new ObjectParameter("staff_id", staff_id) :
                new ObjectParameter("staff_id", typeof(int));
    
            var paid_priceParameter = paid_price.HasValue ?
                new ObjectParameter("paid_price", paid_price) :
                new ObjectParameter("paid_price", typeof(double));
    
            var used_markParameter = used_mark.HasValue ?
                new ObjectParameter("used_mark", used_mark) :
                new ObjectParameter("used_mark", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_Order", order_idParameter, customer_idParameter, staff_idParameter, paid_priceParameter, used_markParameter);
        }
    
        public virtual int SP_UPDATE_OrderDetail(Nullable<int> order_id, Nullable<int> product_id, Nullable<short> quantity)
        {
            var order_idParameter = order_id.HasValue ?
                new ObjectParameter("order_id", order_id) :
                new ObjectParameter("order_id", typeof(int));
    
            var product_idParameter = product_id.HasValue ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_OrderDetail", order_idParameter, product_idParameter, quantityParameter);
        }
    
        public virtual int SP_UPDATE_Product(Nullable<int> productId, string productName, Nullable<int> branId, Nullable<int> catId, Nullable<double> price, Nullable<short> quantity)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("productId", productId) :
                new ObjectParameter("productId", typeof(int));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("productName", productName) :
                new ObjectParameter("productName", typeof(string));
    
            var branIdParameter = branId.HasValue ?
                new ObjectParameter("branId", branId) :
                new ObjectParameter("branId", typeof(int));
    
            var catIdParameter = catId.HasValue ?
                new ObjectParameter("catId", catId) :
                new ObjectParameter("catId", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_Product", productIdParameter, productNameParameter, branIdParameter, catIdParameter, priceParameter, quantityParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int SP_InsertOrderDetail(string json)
        {
            var jsonParameter = json != null ?
                new ObjectParameter("json", json) :
                new ObjectParameter("json", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertOrderDetail", jsonParameter);
        }
    }
}