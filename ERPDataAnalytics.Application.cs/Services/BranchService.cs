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
    public class BranchService : IBranchService
    {
        private readonly IBranchInterface _BranchInterface;

        public BranchService(IBranchInterface BranchInterface)
        {
            _BranchInterface = BranchInterface;
        }

        public Task<ResponseDataModel<Branch>> AddBranch(Branch model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteBranch(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Branch>>> GetAllBranch()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Branch>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Branch>> UpdateBranch(int id, Branch model)
        {
            throw new NotImplementedException();
        }
    }
}
