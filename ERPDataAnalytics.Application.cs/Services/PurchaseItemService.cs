using ERPDataAnalytics.Application.cs.Interface;
using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Services
{
    public class PurchaseItemService : IPurchaseItemService
    {
        private readonly IPurchaseItemInterface _PurchaseItemInterface;

        public PurchaseItemService(IPurchaseItemInterface PurchaseItemInterface)
        {
            _PurchaseItemInterface = PurchaseItemInterface;
        }

        public Task<ResponseDataModel<PurchaseItem>> AddPurchaseItem(PurchaseItem model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeletePurchaseItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<PurchaseItem>>> GetAllPurchaseItem()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<PurchaseItem>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<PurchaseItem>> UpdatePurchaseItem(int id, PurchaseItem model)
        {
            throw new NotImplementedException();
        }
    }
}
