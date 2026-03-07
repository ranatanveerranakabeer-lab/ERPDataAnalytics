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
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceInterface _attendanceInterface;

        public AttendanceService(IAttendanceInterface attendanceInterface)
        {
            _attendanceInterface = attendanceInterface;
        }
        public Task<ResponseDataModel<Attendance>> AddAttendance(Attendance model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteAttendance(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Attendance>>> GetAllAttendance()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Attendance>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Attendance>> UpdateAttendance(int id, Attendance model)
        {
            throw new NotImplementedException();
        }
    }
}
