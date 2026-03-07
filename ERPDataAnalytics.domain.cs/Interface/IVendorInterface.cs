using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
   public interface IVendorInterface
    {
        Task<List<Vendor>> GetVendorList();

        Task<Vendor> GetVendorById(int id);


        Task CreateVendor(Vendor model);


        Task<Vendor> DeleteVendor(int id);

        Task UpdateVendor(Vendor model);
    }
}
