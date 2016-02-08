using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesApp.DataBase
{
    public class Repository: IRepository
    {
        AppDBContext appDBContext = new AppDBContext();

        public IEnumerable<Expense> Get()
        {
            return appDBContext.expenses;
        }
        public Task<IEnumerable<Expense>> GetAsync()
        {
            return Task.Run(() => this.Get());
        }

        public void Add(Expense expense)
        {
            appDBContext.expenses.Add(expense);
            appDBContext.SaveChanges();
        }
        public Task AddAsync(Expense expense)
        {
            return Task.Run(() => this.Add(expense));
        }

        public void AddRange(IEnumerable<Expense> expenses)
        {
            appDBContext.expenses.AddRange(expenses);
            appDBContext.SaveChanges();
        }
    }
}
