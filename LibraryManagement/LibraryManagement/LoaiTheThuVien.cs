//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiTheThuVien
    {
        public LoaiTheThuVien()
        {
            this.DocGias = new HashSet<DocGia>();
        }
    
        public int MaLoaiThe { get; set; }
        public string TenLoaiThe { get; set; }
        public int SoSachToiDa { get; set; }
    
        public virtual ICollection<DocGia> DocGias { get; set; }
    }
}