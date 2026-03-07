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
    public class UserRepository : IUserInterface
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateUser(User model)
        {
            await _dataContext.Users.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }

        public async Task<User> DeleteUser(int id)
        {
            var res = await _dataContext.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Users.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }

        public async Task<User> GetUserById(int id)
        {
            return await _dataContext.Users.FindAsync(id);
        }

        public async Task<List<User>> GetUserList()
        {
            return await _dataContext.Users.ToListAsync();
        }

        public async Task UpdateUser(User model)
        {
            var updatedata = await _dataContext.Users.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.Username= model.Username;
                updatedata.PasswordHash = model.PasswordHash;
                updatedata.BranchId = model.BranchId;
                updatedata.CompanyId = model.CompanyId;
                updatedata.EmployeeId = model.EmployeeId;
                updatedata.RoleName=model.RoleName;
                    _dataContext.Users.Update(updatedata);
                await _dataContext.SaveChangesAsync();





            }
        }
    }
}
