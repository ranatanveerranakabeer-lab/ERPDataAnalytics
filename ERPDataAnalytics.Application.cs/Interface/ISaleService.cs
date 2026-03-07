using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface ISaleService
    {
        Task<ResponseDataModel<List<Sale>>> GetAllSale();

        Task<ResponseDataModel<Sale>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteSale(int id);

        Task<ResponseDataModel<Sale>> UpdateSale(int id, Sale model);


        Task<ResponseDataModel<Sale>> AddSale(Sale model);
    }

}
