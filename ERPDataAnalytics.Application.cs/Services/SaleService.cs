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
    public class SaleService : ISaleService
    {
        private readonly ISaleInterface _Salerepository;

        public SaleService(ISaleInterface SaleInterface)
        {
            _Salerepository = SaleInterface;
        }
        public Task<ResponseDataModel<Sale>> AddSale(Sale model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteSale(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Sale>>> GetAllSale()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Sale>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Sale>> UpdateSale(int id, Sale model)
        {
            throw new NotImplementedException();
        }
    }
}
