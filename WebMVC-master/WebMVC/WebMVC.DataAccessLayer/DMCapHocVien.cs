//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMVC.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class DMCapHocVien
    {
        public DMCapHocVien()
        {
            this.KhoaHocs = new HashSet<KhoaHoc>();
        }
    
        public int MaCapHocVien { get; set; }
        public string TenCapHocVien { get; set; }
        public string MoTa { get; set; }
    
        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
    }
}
