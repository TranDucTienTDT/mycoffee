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
    
    public partial class promote_detail
    {
        public int ID { get; set; }
        public int PromoteID { get; set; }
        public int ProductID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public int Deleted { get; set; }
    
        public virtual product product { get; set; }
        public virtual promote promote { get; set; }
    }
}
