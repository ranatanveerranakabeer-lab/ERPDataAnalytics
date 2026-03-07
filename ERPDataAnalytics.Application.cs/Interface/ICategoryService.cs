using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface ICategoryService
    {
        Task<ResponseDataModel<List<Category>>> GetAllCategory();

        Task<ResponseDataModel<Category>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteCategory(int id);

        Task<ResponseDataModel<Category>> UpdateCategory(int id, Category model);


        Task<ResponseDataModel<Category>> AddCategory(Category model);
    }

}
