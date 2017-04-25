using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LibraryManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceLibrary : IServiceLibrary
    {
        db_libraryEntities db = new db_libraryEntities();
        public List<Khoa> listAllTrade()
        {
            return db.Khoas.ToList();
        }

        public void createTrade(Khoa e)
        {
            db.Khoas.Add(e);
            db.SaveChanges();
        }

        public void deleteTrade(int id)
        {
            Khoa e = db.Khoas.SingleOrDefault(x => x.MaKhoa == id);
            db.Khoas.Remove(e);
            db.SaveChanges();
        }

        public List<LoaiTheThuVien> listAllCardType()
        {
            return db.LoaiTheThuViens.ToList();
        }

        public void createCardType(LoaiTheThuVien e)
        {
            db.LoaiTheThuViens.Add(e);
            db.SaveChanges();
        }

        public void deleteCardType(int id)
        {
            LoaiTheThuVien e = db.LoaiTheThuViens.SingleOrDefault(x => x.MaLoaiThe == id);
            db.LoaiTheThuViens.Remove(e);
            db.SaveChanges();
        }


        public List<DanhMucSach> listAllCategory()
        {
            return db.DanhMucSaches.ToList();
        }

        public void createCategory(DanhMucSach e)
        {
            db.DanhMucSaches.Add(e);
            db.SaveChanges();
        }

        public void deleteCategory(int id)
        {
            DanhMucSach e = db.DanhMucSaches.SingleOrDefault(x => x.MaDanhMuc == id);
            db.DanhMucSaches.Remove(e);
            db.SaveChanges();
        }

        public List<NhaXuatBan> listAllPublisher()
        {
            return db.NhaXuatBans.ToList();
        }

        public void createPublisher(NhaXuatBan e)
        {
            db.NhaXuatBans.Add(e);
            db.SaveChanges();
        }

        public void deletePublisher(int id)
        {
            NhaXuatBan e = db.NhaXuatBans.SingleOrDefault(x => x.MaNXB == id);
            db.NhaXuatBans.Remove(e);
            db.SaveChanges();
        }

        public List<ThuThu> listAllLibrarian()
        {
            return db.ThuThus.ToList();
        }

        public void createLibrarian(ThuThu e)
        {
            db.ThuThus.Add(e);
            db.SaveChanges();
        }

        public void editLibrarian(ThuThu e)
        {
            ThuThu obj = db.ThuThus.SingleOrDefault(x => x.MaThuThu == e.MaThuThu);
            obj.HoTen = e.HoTen;
            obj.NgaySinh = e.NgaySinh;
            obj.DiaChi = e.DiaChi;
            obj.SoDienThoai = e.SoDienThoai;
            obj.MatKhau = e.MatKhau;
            obj.Email = e.Email;
            obj.PhanCap = e.PhanCap;
            db.SaveChanges();
        }

        public void deleteLibrarian(string id)
        {
            ThuThu e = db.ThuThus.SingleOrDefault(x => x.MaThuThu.Equals(id));
            db.ThuThus.Remove(e);
            db.SaveChanges();
        }

        public List<ThuThu> searchLibrarian(string keyword)
        {
            return db.ThuThus.Where(x => x.MaThuThu.Contains(keyword) || x.HoTen.Contains(keyword)).ToList();
        }

        public List<DocGia> listAllReader()
        {
            return db.DocGias.ToList();
        }

        public void createReader(DocGia e)
        {
            db.DocGias.Add(e);
            db.SaveChanges();
        }

        public void editReader(DocGia e)
        {
            DocGia obj = db.DocGias.SingleOrDefault(x => x.MaDocGia == e.MaDocGia);
            obj.HoTen = e.HoTen;
            obj.NgaySinh = e.NgaySinh;
            obj.DiaChi = e.DiaChi;
            obj.SoDienThoai = e.SoDienThoai;
            obj.Email = e.Email;
            obj.MaKhoa = e.MaKhoa;
            obj.MaLoaiThe = e.MaLoaiThe;
            db.SaveChanges();
        }

        public void deleteReader(int id)
        {
            DocGia e = db.DocGias.SingleOrDefault(x => x.MaDocGia == id);
            db.DocGias.Remove(e);
            db.SaveChanges();
        }

        public List<DocGia> searchReader(string keyword)
        {
            return db.DocGias.Where(x => x.HoTen.Contains(keyword)).ToList();
        }

        public List<Sach> listAllBook()
        {
            return db.Saches.ToList();
        }

        public void createBook(Sach e)
        {
            db.Saches.Add(e);
            db.SaveChanges();
        }

        public void editBook(Sach e)
        {
            Sach obj = db.Saches.SingleOrDefault(x => x.MaSach == e.MaSach);
            obj.TieuDeSach = e.TieuDeSach;
            obj.MoTa = e.MoTa;
            obj.SoTrang = e.SoTrang;
            obj.GiaTien = e.GiaTien;
            obj.NgayNhapKho = e.NgayNhapKho;
            obj.SoLuongTon = e.SoLuongTon;
            obj.NamXuatBan = e.NamXuatBan;
            obj.MaNXB = e.MaNXB;
            obj.MaDanhMuc = e.MaDanhMuc;
            db.SaveChanges();
        }

        public void deleteBook(int id)
        {
            Sach e = db.Saches.SingleOrDefault(x => x.MaSach == id);
            db.Saches.Remove(e);
            db.SaveChanges();
        }

        public List<Sach> searchBook(string keyword, string searchType)
        {
            List<Sach> list = new List<Sach>();
            if (searchType.Equals("Nhà xuất bản"))
            {
                var nxb = db.NhaXuatBans.Where(x => x.TenNXB.Contains(keyword)).Select(x => x.MaNXB).ToList();
                var listBook = db.Saches.Where(x => nxb.Contains((int)x.MaNXB)).ToList();
                list.AddRange(listBook);
            }
            if (searchType.Equals("Thể loại"))
            {
                var cate = db.DanhMucSaches.Where(x => x.TenDanhMuc.Contains(keyword)).Select(x => x.MaDanhMuc).ToList();
                var listBook = db.Saches.Where(x => cate.Contains((int)x.MaDanhMuc)).ToList();
                list.AddRange(listBook);
            }
            if (searchType.Equals("Tiêu đề sách"))
            {
                list = db.Saches.Where(x => x.TieuDeSach.Contains(keyword)).ToList();
            }
            if (searchType.Equals("Tác giả"))
            {
                var author = db.TacGias.Where(x => x.HoTen.Contains(keyword)).Select(x => x.MaTacGia).ToList();
                var takepartin = db.ThamGias.Where(x => author.Contains(x.MaTacGia)).Select(x => x.MaSach).ToList();
                var listBook = db.Saches.Where(x => takepartin.Contains(x.MaSach)).ToList();
                list.AddRange(listBook);
            }
            return list;
        }

        public List<TacGia> listAllAuthor()
        {
            return db.TacGias.ToList();
        }

        public void createAuthor(TacGia e)
        {
            db.TacGias.Add(e);
            db.SaveChanges();
        }

        public void deleteAuthor(int id)
        {
            TacGia e = db.TacGias.SingleOrDefault(x => x.MaTacGia == id);
            db.TacGias.Remove(e);
            db.SaveChanges();
        }

        public List<ThamGia> listAllAttend()
        {
            return db.ThamGias.ToList();
        }

        public void createAttend(ThamGia e)
        {
            db.ThamGias.Add(e);
            db.SaveChanges();
        }

        public void deleteAttend(int bookId, int authorId)
        {
            ThamGia e = db.ThamGias.SingleOrDefault(x => x.MaSach == bookId && x.MaTacGia == authorId);
            db.ThamGias.Remove(e);
            db.SaveChanges();
        }

        public List<PhieuMuon> listAllRentCard()
        {
            return db.PhieuMuons.ToList();
        }

        public void createRentCard(PhieuMuon e)
        {
            db.PhieuMuons.Add(e);
            db.SaveChanges();
        }

        public void editRentCard(PhieuMuon e)
        {
            PhieuMuon obj = db.PhieuMuons.SingleOrDefault(x => x.MaPhieuMuon == e.MaPhieuMuon);
            obj.NgayMuon = e.NgayMuon;
            obj.HanTra = e.HanTra;
            obj.NgayTra = e.NgayTra;
            obj.TinhTrangTra = e.TinhTrangTra;
            db.SaveChanges();
        }

        public void deleteRentCard(int id)
        {
            PhieuMuon e = db.PhieuMuons.SingleOrDefault(x => x.MaPhieuMuon == id);
            db.PhieuMuons.Remove(e);
            db.SaveChanges();
        }

        public List<ChiTietMuon> listAllRentDetail(int rentCartId)
        {
            return db.ChiTietMuons.Where(x => x.MaPhieuMuon == rentCartId).ToList();
        }

        public string createRentDetail(ChiTietMuon e)
        {
            ChiTietMuon obj = db.ChiTietMuons.SingleOrDefault(x => x.MaPhieuMuon == e.MaPhieuMuon && x.MaSach == e.MaSach);
            PhieuMuon rentcard = db.PhieuMuons.SingleOrDefault(x => x.MaPhieuMuon == e.MaPhieuMuon);
            DocGia reader = db.DocGias.SingleOrDefault(x => x.MaDocGia == rentcard.MaDocGia);
            LoaiTheThuVien cardtype = db.LoaiTheThuViens.SingleOrDefault(x => x.MaLoaiThe == reader.MaLoaiThe);
            if (obj == null)
            {
                if (countQuantityBookBorrowed(rentcard.MaPhieuMuon) + e.SoLuong <= cardtype.SoSachToiDa)
                {
                    db.ChiTietMuons.Add(e);
                    db.SaveChanges();
                    return "Thêm mới thành công!";
                }
                else
                {
                    return "Thẻ của bạn không thể mượn quá số lượng!";
                }
            }
            else
            {
                if (e.SoLuong <= cardtype.SoSachToiDa)
                {
                    obj.SoLuong = e.SoLuong;
                    db.SaveChanges();
                    return "Bản ghi đã tồn tại. Chỉ có thể thay đổi số lượng!";
                }
                else
                {
                    return "Thẻ của bạn không thể mượn quá số lượng!";
                }
            }
        }

        public void editRentDetail(ChiTietMuon e)
        {
            ChiTietMuon obj = db.ChiTietMuons.SingleOrDefault(x => x.MaPhieuMuon == e.MaPhieuMuon && x.MaSach == e.MaSach);
            obj.SoLuong = e.SoLuong;
            db.SaveChanges();
        }

        public void deleteRentDetail(int rentCardId, int bookId)
        {
            ChiTietMuon e = db.ChiTietMuons.SingleOrDefault(x => x.MaPhieuMuon == rentCardId && x.MaSach == bookId);
            db.ChiTietMuons.Remove(e);
            db.SaveChanges();
        }

        public int countQuantityBookBorrowed(int rentCardId)
        {
            int sum = 0;
            List<ChiTietMuon> list = db.ChiTietMuons.Where(x => x.MaPhieuMuon == rentCardId).ToList();
            foreach (ChiTietMuon item in list)
            {
                sum += item.SoLuong;
            }
            return sum;
        }


        public List<PhieuMuon> listRentOverTime()
        {
            return db.PhieuMuons.Where(x => x.TinhTrangTra == false && DateTime.Compare(x.HanTra, DateTime.Now) > 0).ToList();
        }
    }
}
