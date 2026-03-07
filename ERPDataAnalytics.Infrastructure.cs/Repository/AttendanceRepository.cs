using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Infrastructure.cs.Repository
{
   public class AttendanceRepository : IAttendanceInterface
    {
        private readonly DataContext _dataContext;
        public AttendanceRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateAttendane(Attendance model)
        {
          await _dataContext.Attendances.AddAsync(model); 
            await _dataContext.SaveChangesAsync();
           
        }

        public async Task<Attendance> DeleteAttendance(int id)
        {
            var res = await _dataContext.Attendances.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (res != null)
            {
                _dataContext.Attendances.Remove(res);
                await _dataContext.SaveChangesAsync();  
            }
            return null;
        }

        public async Task<Attendance> GetAttendance(int id)
        {
            return await _dataContext.Attendances.FindAsync(id);
        }

        public async Task<List<Attendance>> GetAttendanceList()
        {
            return await _dataContext.Attendances.ToListAsync();
        }

        public async Task UpdateAttendance(Attendance model)
        {
             var updatedata = await _dataContext.Attendances.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null) {
       
                updatedata.AttendanceDate = DateTime.Now;
                updatedata.ShiftId=model.ShiftId;
                updatedata.CheckIn=model.CheckIn;   
                updatedata.CheckOut=model.CheckOut;
                updatedata.EmployeeId=model.EmployeeId;
             _dataContext.Attendances.Update(updatedata);
                await _dataContext.SaveChangesAsync();  



            
            
            }
        }
    }
}
