using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.DTO.User
{
    public class LoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class LoginResponseDTO
    {
        public string  Username { get; set; }
        public int UserID { get; set; }
        public string Token { get; set; }
        public int  RoleId { get; set; }

    }
    public class UserDTO
    {
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int EmployeeId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; } // encrypted hu ga
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
    }
    }
