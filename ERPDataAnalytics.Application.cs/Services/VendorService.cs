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
    public class VendorService : IVendorService
    {
        private readonly IVendorInterface _Vendorrepository;

        public VendorService(IVendorInterface VendorInterface)
        {
            _Vendorrepository = VendorInterface;
        }


        public Task<ResponseDataModel<Vendor>> AddVendor(Vendor model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteVendor(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Vendor>>> GetAllVendor()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Vendor>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Vendor>> UpdateVendor(int id, Vendor model)
        {
            throw new NotImplementedException();
        }
    }
}
