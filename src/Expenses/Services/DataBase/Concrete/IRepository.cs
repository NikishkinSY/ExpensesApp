using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesApp.DataBase
{
    public interface IRepository
    {
        IEnumerable<Expense> Get();
        Task<IEnumerable<Expense>> GetAsync();
        void Add(Expense expense);
        Task AddAsync(Expense expense);
        void AddRange(IEnumerable<Expense> expenses);
    }
}
