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
    
    public partial class phieuchi
    {
        public int MaPC { get; set; }
        public string PCCode { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<System.DateTime> NgayChi { get; set; }
        public Nullable<decimal> SoTienDaTra_PC { get; set; }
        public string LyDo { get; set; }
        public string DoiTuongChi { get; set; }
        public string DiaChi { get; set; }
        public string GhiChu { get; set; }
        public string DinhKem { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
