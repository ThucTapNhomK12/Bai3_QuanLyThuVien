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
    
    public partial class Sach
    {
        public Sach()
        {
            this.ChiTietMuons = new HashSet<ChiTietMuon>();
            this.ThamGias = new HashSet<ThamGia>();
        }
    
        public int MaSach { get; set; }
        public string TieuDeSach { get; set; }
        public string MoTa { get; set; }
        public int SoTrang { get; set; }
        public double GiaTien { get; set; }
        public System.DateTime NgayNhapKho { get; set; }
        public int SoLuongTon { get; set; }
        public int NamXuatBan { get; set; }
        public Nullable<int> MaNXB { get; set; }
        public Nullable<int> MaDanhMuc { get; set; }
    
        public virtual ICollection<ChiTietMuon> ChiTietMuons { get; set; }
        public virtual DanhMucSach DanhMucSach { get; set; }
        public virtual NhaXuatBan NhaXuatBan { get; set; }
        public virtual ICollection<ThamGia> ThamGias { get; set; }
    }
}
