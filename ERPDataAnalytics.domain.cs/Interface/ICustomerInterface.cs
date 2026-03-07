using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
   public interface  ICustomerInterface
    {
        Task<List<Customer>> GetCustomerList();

        Task<Customer> GetCustomerById(int id);


        Task CreateCustomer(Customer model);


        Task<Customer> DeleteCustomer(int id);

        Task  UpdateCustomer(Customer model);
    }
}
