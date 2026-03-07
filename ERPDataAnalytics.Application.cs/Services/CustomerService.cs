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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerInterface _CustomerInterface;

        public CustomerService(ICustomerInterface CustomerInterface)
        {
            _CustomerInterface = CustomerInterface;
        }

        public Task<ResponseDataModel<Customer>> AddCustomer(Customer model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Customer>>> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Customer>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Customer>> UpdateCustomer(int id, Customer model)
        {
            throw new NotImplementedException();
        }
    }
}
