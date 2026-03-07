using ERPDataAnalytics.domain.cs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.domain.cs.Interface
{
   public interface IExpenseInterface
    {
        Task<List<Expense>> GetExpenseList();

        Task<Expense> GetExpenseById(int id);


        Task  CreateExpense(Expense model);


        Task<Expense> DeleteExpense(int id);

        Task UpdateExpense(Expense model);
    }
}
