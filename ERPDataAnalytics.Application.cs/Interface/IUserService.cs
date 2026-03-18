using ERPDataAnalytics.Application.cs.DTO.User;
using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface IUserService
    {
        Task<ResponseDataModel<List<User>>> GetAllUser();

        Task<ResponseDataModel<User>> GetById(int id);

        Task<ResponseDataModel<LoginResponseDTO>> LoginUser( LoginDTO  login, CancellationToken  cancellationToken);
        Task<ResponseDataModel<bool>> Signup( User  signupuser, CancellationToken  cancellationToken);


        Task<ResponseDataModel<bool>> DeleteUser(int id);

        Task<ResponseDataModel<User>> UpdateUser(int id, User model);


        Task<ResponseDataModel<User>> AddUser(User dto);
    }
}
