using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
   public interface IProductService
    {
        Task<ResponseDataModel<List<Product>>> GetAllProduct();

        Task<ResponseDataModel<Product>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteProduct(int id);

        Task<ResponseDataModel<Product>> UpdateProduct(int id, Product model);


        Task<ResponseDataModel<Product>> AddProduct(Product model);
    }
}
