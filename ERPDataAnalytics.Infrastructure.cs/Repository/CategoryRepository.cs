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
    public class CategoryRepository : ICategoryInterface
    {
        private readonly DataContext _dataContext;
        public CategoryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task CreateCategory(Category model)
        {
            await _dataContext.Categories.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }

        public async Task<Category> DeleteCategory(int id)
        {
            var res = await _dataContext.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Categories.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _dataContext.Categories.FindAsync(id);
        }

        public async Task<List<Category>> GetCategoryList()
        {
            return await _dataContext.Categories.ToListAsync();
        }

        public async Task UpdateCategory(Category model)
        {
            var updatedata = await _dataContext.Categories.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.Name = model.Name;
                updatedata.CompanyId= model.CompanyId;
                 _dataContext.Categories.Update(updatedata);
                await _dataContext.SaveChangesAsync();





            }
        }
    }
}
