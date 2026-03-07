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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryInterface _CategoryInterface;

        public CategoryService(ICategoryInterface CategoryInterface)
        {
            _CategoryInterface = CategoryInterface;
        }

        public Task<ResponseDataModel<Category>> AddCategory(Category model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Category>>> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Category>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Category>> UpdateCategory(int id, Category model)
        {
            throw new NotImplementedException();
        }
    }
}
