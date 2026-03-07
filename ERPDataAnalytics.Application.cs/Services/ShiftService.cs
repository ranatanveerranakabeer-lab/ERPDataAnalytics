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
    public class ShiftService : IShiftService
    {
        private readonly IShiftInterface _Shiftrepository;

        public ShiftService(IShiftInterface ShiftInterface)
        {
            _Shiftrepository = ShiftInterface;
        }


        public Task<ResponseDataModel<Shift>> AddShift(Shift model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteShift(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Shift>>> GetAllShift()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Shift>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Shift>> UpdateShift(int id, Shift model)
        {
            throw new NotImplementedException();
        }
    }
}
