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
    
    public partial class money_trading
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public decimal TotalMoney { get; set; }
        public decimal MoneyCredit { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public int Status { get; set; }
        public Nullable<int> ReceiveByEmployeeID { get; set; }
        public string ReceiveByEmployeeName { get; set; }
        public string Notes { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
