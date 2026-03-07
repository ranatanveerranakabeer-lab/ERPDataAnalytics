using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
   public interface IProductInterface
    {
        Task<List<Product>> GetProductList();

        Task<Product> GetProductById(int id);


        Task CreateProduct(Product model);


        Task<Product> DeleteProduct(int id);

        Task UpdateProduct(Product model);
    }
}
