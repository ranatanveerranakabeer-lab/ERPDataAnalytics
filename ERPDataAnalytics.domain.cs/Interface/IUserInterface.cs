using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
    public interface IUserInterface
    {
        Task<List<User>> GetUserList();

        Task<User> GetUserById(int id);


        Task CreateUser(User model);


        Task<User> DeleteUser(int id);

        Task  UpdateUser(User model);
    }
}
