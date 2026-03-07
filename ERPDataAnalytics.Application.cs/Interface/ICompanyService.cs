using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
   public interface ICompanyService
    {
        Task<ResponseDataModel<List<Company>>> GetAllCompany();

        Task<ResponseDataModel<Company>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteCompany(int id);

        Task<ResponseDataModel<Company>> UpdateCompany(int id, Company model);


        Task<ResponseDataModel<Company>> AddCompany(Company model);
    }
}
