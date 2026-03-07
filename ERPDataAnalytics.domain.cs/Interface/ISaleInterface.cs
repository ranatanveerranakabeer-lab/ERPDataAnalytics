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


        Task CreateSale(Sale model);


        Task<Sale> DeleteSale(int id);

        Task UpdateSale(Sale model);
    }
}
