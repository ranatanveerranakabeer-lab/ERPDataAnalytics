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
    public class ProductService : IProductService
    {
        private readonly IProductInterface _ProductInterface;

        public ProductService(IProductInterface ProductInterface)
        {
            _ProductInterface = ProductInterface;
        }

        public Task<ResponseDataModel<Product>> AddProduct(Product model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Product>>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Product>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Product>> UpdateProduct(int id, Product model)
        {
            throw new NotImplementedException();
        }
    }
}
