using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface IAttendanceService
    {
        Task<ResponseDataModel<List<Attendance>>> GetAllAttendance();
           
        Task<ResponseDataModel<Attendance>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteAttendance(int id);

        Task<ResponseDataModel<Attendance>> UpdateAttendance(int id, Attendance model);


        Task<ResponseDataModel<Attendance>> AddAttendance(Attendance model);
    }
}
