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
    
    public partial class smartlink
    {
        public smartlink()
        {
            this.khachhangs = new HashSet<khachhang>();
        }
    
        public int ID { get; set; }
        public string SmarkLink { get; set; }
        public Nullable<decimal> LevelMoney { get; set; }
        public double Percent_SmarkLink { get; set; }
        public int Status { get; set; }
    
        public virtual ICollection<khachhang> khachhangs { get; set; }
    }
}
