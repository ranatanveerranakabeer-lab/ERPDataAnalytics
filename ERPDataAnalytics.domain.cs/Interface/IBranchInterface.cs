using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
    public  interface IBranchInterface
    {
        Task<List<Branch>> GetBranchList();

        Task<Branch> GetBranchById(int id);


        Task  CreateBranch(Branch model);


        Task<Branch> DeleteBranch(int id);

        Task UpdateBranch(Branch model);
    }
}
