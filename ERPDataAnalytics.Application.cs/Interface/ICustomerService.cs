using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
   public interface  ICustomerService
    {
        Task<ResponseDataModel<List<Customer>>> GetAllCustomer();

        Task<ResponseDataModel<Customer>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteCustomer(int id);

        Task<ResponseDataModel<Customer>> UpdateCustomer(int id, Customer model);


        Task<ResponseDataModel<Customer>> AddCustomer(Customer model);
    }
}
