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
    
    public partial class khuvuc
    {
        public khuvuc()
        {
            this.khachhangs = new HashSet<khachhang>();
        }
    
        public int makv { get; set; }
        public string tenkv { get; set; }
        public string ghichu { get; set; }
        public Nullable<int> tinhtrang { get; set; }
    
        public virtual ICollection<khachhang> khachhangs { get; set; }
    }
}
