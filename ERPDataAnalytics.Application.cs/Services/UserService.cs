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
    public class UserService : IUserService
    {
         private readonly IUserInterface _userrepository;

        public UserService(IUserInterface userInterface)
        {
           _userrepository = userInterface;
        }

        public Task<ResponseDataModel<User>> AddUser(User model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<User>>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<User>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<User>> UpdateUser(int id, User model)
        {
            throw new NotImplementedException();
        }
    }
}
