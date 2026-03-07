using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public  interface IBranchService
    {
        Task<ResponseDataModel<List<Branch>>> GetAllBranch();

        Task<ResponseDataModel<Branch>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteBranch(int id);

        Task<ResponseDataModel<Branch>> UpdateBranch(int id, Branch model);


        Task<ResponseDataModel<Branch>> AddBranch(Branch model);
    }
}
