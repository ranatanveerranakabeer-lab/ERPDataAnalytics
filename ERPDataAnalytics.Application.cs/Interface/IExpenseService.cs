using ERPDataAnalytics.Application.cs.Model;
using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Application.cs.Interface
{
   public interface IExpenseService
    {
        Task<ResponseDataModel<List<Expense>>> GetAllExpense();

        Task<ResponseDataModel<Expense>> GetById(int id);

        Task<ResponseDataModel<bool>> DeleteExpense(int id);

        Task<ResponseDataModel<Expense>> UpdateExpense(int id, Expense model);


        Task<ResponseDataModel<Expense>> AddExpense(Expense model);
    }
}
