using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
   public interface IVendorService
    {
        Task<ResponseDataModel<List<Vendor>>> GetAllVendor();

        Task<ResponseDataModel<Vendor>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteVendor(int id);

        Task<ResponseDataModel<Vendor>> UpdateVendor(int id, Vendor model);


        Task<ResponseDataModel<Vendor>> AddVendor(Vendor model);
    }
}
