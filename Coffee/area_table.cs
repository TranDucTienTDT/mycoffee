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
    
    public partial class area_table
    {
        public area_table()
        {
            this.listorders = new HashSet<listorder>();
        }
    
        public int TableID { get; set; }
        public string TableCode { get; set; }
        public int AreaID { get; set; }
        public int Status { get; set; }
        public int Empty { get; set; }
        public int ImageIndex { get; set; }
    
        public virtual area area { get; set; }
        public virtual ICollection<listorder> listorders { get; set; }
    }
}
