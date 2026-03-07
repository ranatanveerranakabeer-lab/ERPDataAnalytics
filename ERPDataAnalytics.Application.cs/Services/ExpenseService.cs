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
    public class  ExpenseService : IExpenseService
    {
        private readonly IAttendanceInterface _attendanceInterface;

        public ExpenseService(IAttendanceInterface ExpenseInterface)
        {
            _attendanceInterface = ExpenseInterface;
        }

        public Task<ResponseDataModel<Expense>> AddExpense(Expense model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<bool>> DeleteExpense(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<List<Expense>>> GetAllExpense()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Expense>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDataModel<Expense>> UpdateExpense(int id, Expense model)
        {
            throw new NotImplementedException();
        }
    }
}
