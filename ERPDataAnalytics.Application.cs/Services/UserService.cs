using BCrypt.Net;
using ERPDataAnalytics.Application.cs.DTO.User;
using ERPDataAnalytics.Application.cs.Interface;
using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Services
{
    public class UserService : IUserService
    {
         private readonly IUserInterface _userrepository;
        private readonly  string _secretkey;
        
        public UserService(IUserInterface userInterface,IConfiguration configuration)
        {
           _userrepository = userInterface;
            _secretkey = configuration["Jwt:Key"] ;
        }

        public async Task<ResponseDataModel<User>> AddUser(User dto)
        {

            var response = await _userrepository.CreateUser(dto);            

            return ResponseDataModel<User>.SuccessResponse(response, "User created successfully");
            
        }

        public async Task<ResponseDataModel<bool>> DeleteUser(int id)
        {
            var deleteuser= await _userrepository.GetUserById(id);
            if (deleteuser == null)
                return ResponseDataModel<bool>.FailureResponse("user not delete");
            await _userrepository.DeleteUser(deleteuser.Id);
            return ResponseDataModel<bool>.SuccessResponse(true,"User delete successfully");


        }

        public async Task<ResponseDataModel<List<User>>> GetAllUser()
        {
            var userlist= await _userrepository.GetUserList();
            return ResponseDataModel<List<User>>.SuccessResponse(userlist, "User list get successfully");
        }

        public async Task<ResponseDataModel<User>> GetById(int id)
        {
            var userlist = await _userrepository.GetUserById(id);
            return ResponseDataModel<User>.SuccessResponse(userlist, "User  get successfully");
        }

        public async Task<ResponseDataModel<LoginResponseDTO>> LoginUser(LoginDTO loginDTO  , CancellationToken cancellationToken)
        {
            var user = await _userrepository.GetByEmail(loginDTO.Email, cancellationToken);
            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDTO.Password, user.PasswordHash))
                return ResponseDataModel<LoginResponseDTO>.FailureResponse("Invalid Email or Password");

            if(!user.IsActive)
                return ResponseDataModel<LoginResponseDTO>.FailureResponse("Inactive user");

            var token = GenerateToken(user);

            var response = new LoginResponseDTO
            {
                UserID = user.Id,
                RoleId = user.RoleId,
                Username = user.Username,
                Token = token,

            };
            return ResponseDataModel<LoginResponseDTO>.SuccessResponse( response,"Login Success");

        }
        private string GenerateToken (User user )
        {
            var Claim = new[]
            {

    new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
    new Claim(ClaimTypes.Name,user.Username),
    new Claim(ClaimTypes.Role,user.RoleId.ToString()),

};
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretkey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
               claims: Claim,
               expires: DateTime.UtcNow.AddHours(5),
                signingCredentials: creds
                );
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public async Task<ResponseDataModel<User>> UpdateUser(int id, User model)
        {
           var updateuser= await _userrepository.GetUserById(id);
            if (updateuser == null)
                return ResponseDataModel<User>.FailureResponse("User not exist");
      updateuser.Username = model.Username;
      updateuser.PasswordHash = model.PasswordHash;
           updateuser.BranchId=model.BranchId;   
           updateuser.CompanyId=model.CompanyId;
            updateuser.Email=model.Email;
            updateuser.EmployeeId   =model.EmployeeId;
            updateuser.RoleId=model.RoleId;
            updateuser.IsActive=model.IsActive;

      await  _userrepository.UpdateUser(updateuser);
          return ResponseDataModel<User>.SuccessResponse(updateuser,"User update successfully");
        
        }


        public async Task<ResponseDataModel<bool>> Signup(User signupuser, CancellationToken cancellationToken)
        {
            var userlist= await  _userrepository.GetByEmail(signupuser.Email,cancellationToken);
            if (userlist != null)
                return ResponseDataModel<bool>.FailureResponse("Email already exist");
            var user = new User
            {
               Username=signupuser.Username, 
                Email=signupuser.Email,
                PasswordHash= BCrypt.Net.BCrypt.HashPassword(signupuser.PasswordHash),
                BranchId=signupuser.BranchId,
                RoleId=signupuser.RoleId,
               CompanyId=signupuser.CompanyId,
               EmployeeId=signupuser.EmployeeId,
               IsActive  =signupuser.IsActive,

            };
            _userrepository.CreateUser(user);
            return ResponseDataModel<bool>.SuccessResponse(true,"Signup Success");

        }
    }
}
