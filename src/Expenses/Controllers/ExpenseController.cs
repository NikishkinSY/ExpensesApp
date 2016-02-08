using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ExpensesApp.DataBase;

namespace ExpensesApp.Controllers
{
    public class ExpenseController : Controller
    {
        IRepository repository { get; set; }
        public ExpenseController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IEnumerable<Expense>> Get()
        {
            return await repository.GetAsync();
        }
        
        public async Task Save([FromBody]Expense Expense)
        {
            await repository.AddAsync(Expense);
        }

        public IEnumerable<string> GetCategories()
        {
            return Enum.GetNames(typeof(Category)).Cast<string>();
        }
    }
}
