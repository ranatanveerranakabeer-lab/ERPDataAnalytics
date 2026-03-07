using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
   public interface ICompanyInterface
    {
        Task<List<Company>> GetCompanyList();

        Task<Company> GetCompanyById(int id);


        Task CreateCompany(Company model);


        Task<Company> DeleteCompany(int id);

        Task UpdateCompany(Company model);
    }
}
