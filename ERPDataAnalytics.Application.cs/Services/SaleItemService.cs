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
    public class SaleItemService : ISaleItemService
    {
        private readonly ISaleItemInterface _SaleItemInterface;

        public SaleItemService(ISaleItemInterface SaleItemInterface)
        {
            _SaleItemInterface = SaleItemInterface;
        }

        public Task<ResponseDataModel<SaleItem>> AddSaleItem(SaleItem model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteSaleItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<SaleItem>>> GetAllSaleItem()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<SaleItem>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<SaleItem>> UpdateSaleItem(int id, SaleItem model)
        {
            throw new NotImplementedException();
        }
    }
}
