using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
    public interface IPurchaseInterface
    {
        Task<List<Purchase>> GetPurchaseList();

        Task<Purchase> GetPurchaseById(int id);


        Task CreatePurchase(Purchase model);


        Task<Purchase> DeletePurchase(int id);

        Task UpdatePurchase(Purchase model);
    }
}
