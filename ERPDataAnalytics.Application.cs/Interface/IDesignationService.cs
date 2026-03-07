using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
    public interface IDesignationService
    {
        Task<ResponseDataModel<List<Designation>>> GetAllDesignation();

        Task<ResponseDataModel<Designation>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteDesignation(int id);

        Task<ResponseDataModel<Designation>> UpdateDesignation(int id, Designation model);


        Task<ResponseDataModel<Designation>> AddDesignation(Designation model);
    }
}
