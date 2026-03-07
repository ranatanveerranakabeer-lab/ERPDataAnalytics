using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface IPurchaseService 
    {
        Task<ResponseDataModel<List<Purchase>>> GetAllPurchase();

        Task<ResponseDataModel<Purchase>> GetById(int id);

        Task<ResponseDataModel<bool>> DeletePurchase(int id);

        Task<ResponseDataModel<Purchase>> UpdatePurchase(int id, Purchase model);


        Task<ResponseDataModel<Purchase>> AddPurchase(Purchase model);
    }
}
