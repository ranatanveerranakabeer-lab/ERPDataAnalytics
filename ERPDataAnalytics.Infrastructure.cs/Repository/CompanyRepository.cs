using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Infrastructure.cs.Repository
{
    public class CompanyRepository : ICompanyInterface
    {
        private readonly DataContext _dataContext;
        public CompanyRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Company> DeleteCompany(int id)
        {
            var res = await _dataContext.Companies.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Companies.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateCompany(Company model)
        {
            await _dataContext.Companies.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }
        public async Task<Company> GetCompanyById(int id)
        {
            return await _dataContext.Companies.FindAsync(id);
        }

        public async Task<List<Company>> GetCompanyList()
        {
            return await _dataContext.Companies.ToListAsync();
        }

        public async Task UpdateCompany(Company model)
        {
            var updatedata = await _dataContext.Companies.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.TaxNumber = model.TaxNumber;
                updatedata.CompanyName = model.CompanyName;
                _dataContext.Companies.Update(updatedata);
                await _dataContext.SaveChangesAsync();

                            }
        }
    }
}