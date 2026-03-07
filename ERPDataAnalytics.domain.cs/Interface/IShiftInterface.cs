using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
  public interface IShiftInterface
    {
        Task<List<Shift>> GetShiftList();

        Task <Shift>   GetShiftById(int id);

        Task  CreateShift(Shift model);


        Task<Shift> DeleteShift(int id);

        Task  UpdateShift(Shift model);
    }
}
