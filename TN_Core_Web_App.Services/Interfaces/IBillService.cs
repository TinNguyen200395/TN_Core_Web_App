using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Data.Enums;
using TN_Core_Web_App.Services.ViewModels.Product;
using TN_Core_Web_App.Utilities.DTO;

namespace TN_Core_Web_App.Services.Interfaces
{
    public interface IBillService
    {
        void Create(BillViewModel billVm);
        void Update(BillViewModel billVm);

        PagedResult<BillViewModel> GetAllPaging(string startDate, string endDate, string keyword,
            int pageIndex, int pageSize);

        BillViewModel GetDetail(int billId);

        BillDetailViewModel CreateDetail(BillDetailViewModel billDetailVm);

        void DeleteDetail(int productId, int billId, int colorId, int sizeId);

        void UpdateStatus(int orderId, BillStatus status);

        List<BillDetailViewModel> GetBillDetails(int billId);

        List<ColorViewModel> GetColors();

        List<SizeViewModel> GetSizes();

        void Save();

        ColorViewModel GetColor(int id);

        SizeViewModel GetSize(int id);
    }
}
