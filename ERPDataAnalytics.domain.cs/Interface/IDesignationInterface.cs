using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
    public interface IDesignationInterface
    {
        Task<List<Designation>> GetDesignationList();

        Task<Designation> GetDesignationById(int id);


        Task  CreateDesignation(Designation model);


        Task<Designation> DeleteDesignation(int id);

        Task UpdateDesignation(Designation model);
    }
}
