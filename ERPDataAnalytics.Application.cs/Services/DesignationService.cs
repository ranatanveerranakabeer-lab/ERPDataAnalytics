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
    public class DesignationService : IDesignationService
    {
        private readonly IDesignationInterface _DesignationInterface;

        public DesignationService(IDesignationInterface DesignationInterface)
        {
            _DesignationInterface = DesignationInterface;
        }

        public Task<ResponseDataModel<Designation>> AddDesignation(Designation model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteDesignation(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Designation>>> GetAllDesignation()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Designation>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Designation>> UpdateDesignation(int id, Designation model)
        {
            throw new NotImplementedException();
        }
    }
}
