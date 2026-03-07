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
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseInterface _PurchaseInterface;

        public PurchaseService(IPurchaseInterface PurchaseInterface)
        {
            _PurchaseInterface = PurchaseInterface;
        }

        public Task<ResponseDataModel<Purchase>> AddPurchase(Purchase model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeletePurchase(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Purchase>>> GetAllPurchase()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Purchase>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Purchase>> UpdatePurchase(int id, Purchase model)
        {
            throw new NotImplementedException();
        }
    }
}
