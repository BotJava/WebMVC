﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;

    public partial class DMQuyenQuanTri
    {
        public DMQuyenQuanTri()
        {
            this.QuanTriViens = new HashSet<QuanTriVien>();
        }

        [Display(Name = "Mã quản trị viên")]
        public int MaQuyenQuanTri { get; set; }

        [Display(Name = "Tên quyền quản trị")]
        public string TenQuyenQuanTri { get; set; }

        public virtual ICollection<QuanTriVien> QuanTriViens { get; set; }
    }
}