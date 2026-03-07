using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
  public interface IShiftService
    {
        Task<ResponseDataModel<List<Shift>>> GetAllShift();

        Task<ResponseDataModel<Shift>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteShift(int id);

        Task<ResponseDataModel<Shift>> UpdateShift(int id, Shift model);


        Task<ResponseDataModel<Shift>> AddShift(Shift model);
    }
}
