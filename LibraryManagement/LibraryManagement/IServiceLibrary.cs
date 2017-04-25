using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LibraryManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceLibrary
    {
        [OperationContract]
        List<Khoa> listAllTrade();

        [OperationContract]
        void createTrade(Khoa e);

        [OperationContract]
        void deleteTrade(int id);

        [OperationContract]
        List<LoaiTheThuVien> listAllCardType();

        [OperationContract]
        void createCardType(LoaiTheThuVien e);

        [OperationContract]
        void deleteCardType(int id);

        [OperationContract]
        List<DanhMucSach> listAllCategory();

        [OperationContract]
        void createCategory(DanhMucSach e);

        [OperationContract]
        void deleteCategory(int id);

        [OperationContract]
        List<NhaXuatBan> listAllPublisher();

        [OperationContract]
        void createPublisher(NhaXuatBan e);

        [OperationContract]
        void deletePublisher(int id);

        [OperationContract]
        List<ThuThu> listAllLibrarian();

        [OperationContract]
        void createLibrarian(ThuThu e);

        [OperationContract]
        void editLibrarian(ThuThu e);

        [OperationContract]
        void deleteLibrarian(string id);

        [OperationContract]
        List<ThuThu> searchLibrarian(string keyword);

        [OperationContract]
        List<DocGia> listAllReader();

        [OperationContract]
        void createReader(DocGia e);

        [OperationContract]
        void editReader(DocGia e);

        [OperationContract]
        void deleteReader(int id);

        [OperationContract]
        List<DocGia> searchReader(string keyword);

        [OperationContract]
        List<Sach> listAllBook();

        [OperationContract]
        void createBook(Sach e);

        [OperationContract]
        void editBook(Sach e);

        [OperationContract]
        void deleteBook(int id);

        [OperationContract]
        List<Sach> searchBook(string keyword, string searchType);

        [OperationContract]
        List<TacGia> listAllAuthor();

        [OperationContract]
        void createAuthor(TacGia e);

        [OperationContract]
        void deleteAuthor(int id);

        [OperationContract]
        List<ThamGia> listAllAttend();

        [OperationContract]
        void createAttend(ThamGia e);

        [OperationContract]
        void deleteAttend(int bookId, int authorId);

        [OperationContract]
        List<PhieuMuon> listAllRentCard();

        [OperationContract]
        void createRentCard(PhieuMuon e);

        [OperationContract]
        void editRentCard(PhieuMuon e);

        [OperationContract]
        void deleteRentCard(int id);

        [OperationContract]
        List<ChiTietMuon> listAllRentDetail(int rentCardId);

        [OperationContract]
        string createRentDetail(ChiTietMuon e);

        [OperationContract]
        void editRentDetail(ChiTietMuon e);

        [OperationContract]
        void deleteRentDetail(int rentCardId, int bookId);

        [OperationContract]
        int countQuantityBookBorrowed(int rentCardId);

        [OperationContract]
        List<PhieuMuon> listRentOverTime();
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        
    }
}
