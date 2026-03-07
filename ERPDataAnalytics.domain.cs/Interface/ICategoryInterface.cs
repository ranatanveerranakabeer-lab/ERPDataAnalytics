using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
    public interface ICategoryInterface
    {
        Task<List<Category>> GetCategoryList();

        Task<Category> GetCategoryById(int id);

        Task  CreateCategory(Category model);

        Task<Category> DeleteCategory(int id);

        Task UpdateCategory(Category model);
    }
}
