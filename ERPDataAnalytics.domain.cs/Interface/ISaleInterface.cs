using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
    public interface ISaleInterface
    {
        Task<List<Sale>> GetSaleList();

        Task<Sale> GetSaleById(int id);


        Task <Sale> CreateSale(Sale model);


        Task<bool> DeleteSale(int id);

        Task <Sale> UpdateSale(Sale model);
    }
}
