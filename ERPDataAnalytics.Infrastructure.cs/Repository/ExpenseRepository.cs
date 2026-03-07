using ERPDataAnalytics.domain.cs.Entities;
using ERPDataAnalytics.domain.cs.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPDataAnalytics.Infrastructure.cs.Repository
{
    public class ExpenseRepository : IExpenseInterface
    {
private readonly DataContext _dataContext;
        public ExpenseRepository(DataContext dataContext)
        {
            _dataContext = dataContext; 
        }

        public async Task<Expense> DeleteExpense(int id)
        {
            var res = await _dataContext.Expenses.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _dataContext.Expenses.Remove(res);
                await _dataContext.SaveChangesAsync();
            }
            return null;
        }
        public async Task CreateExpense(Expense model)
        {
            await _dataContext.Expenses.AddAsync(model);
            await _dataContext.SaveChangesAsync();

        }
        public async Task<Expense> GetExpenseById(int id)
        {
            return await _dataContext.Expenses.FindAsync(id);
        }

        public async Task<List<Expense>> GetExpenseList()
        {
            return await _dataContext.Expenses.ToListAsync();
        }

        public async Task UpdateExpense(Expense model)
        {
            var updatedata = await _dataContext.Expenses.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (updatedata != null)
            {

                updatedata.Title = model.Title;
                updatedata.BranchId = model.BranchId;
                updatedata.ExpenseDate = model.ExpenseDate;
                updatedata.Amount=model.Amount;              
                _dataContext.Expenses.Update(updatedata);
                await _dataContext.SaveChangesAsync();

            }
        }
    }
}
