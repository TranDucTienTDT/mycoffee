//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coffee
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public product()
        {
            this.chitiethdns = new HashSet<chitiethdn>();
            this.chitiethoadontras = new HashSet<chitiethoadontra>();
            this.determines = new HashSet<determine>();
            this.order_detail = new HashSet<order_detail>();
            this.promote_detail = new HashSet<promote_detail>();
            this.tonkhoes = new HashSet<tonkho>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> InputPrice { get; set; }
        public string Notes { get; set; }
        public int Status { get; set; }
        public int MadeInID { get; set; }
        public int ProductSkin { get; set; }
        public int ImageIndex { get; set; }
        public string StockID { get; set; }
        public Nullable<int> DVT { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<double> ExchangeQuantity { get; set; }
        public Nullable<int> ExchangeDVT { get; set; }
        public Nullable<int> Type { get; set; }
    
        public virtual ICollection<chitiethdn> chitiethdns { get; set; }
        public virtual ICollection<chitiethoadontra> chitiethoadontras { get; set; }
        public virtual ICollection<determine> determines { get; set; }
        public virtual donvitinh donvitinh { get; set; }
        public virtual icon icon { get; set; }
        public virtual kho kho { get; set; }
        public virtual madein madein { get; set; }
        public virtual menu menu { get; set; }
        public virtual ICollection<order_detail> order_detail { get; set; }
        public virtual ICollection<promote_detail> promote_detail { get; set; }
        public virtual ICollection<tonkho> tonkhoes { get; set; }
    }
}
