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
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyInterface _CompanyInterface;

        public CompanyService(ICompanyInterface CompanyInterface)
        {
            _CompanyInterface = CompanyInterface;
        }

        public Task<ResponseDataModel<Company>> AddCompany(Company model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteCompany(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Company>>> GetAllCompany()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Company>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Company>> UpdateCompany(int id, Company model)
        {
            throw new NotImplementedException();
        }
    }
}
