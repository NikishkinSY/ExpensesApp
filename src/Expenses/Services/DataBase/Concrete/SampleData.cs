using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesApp.DataBase
{
    public static class SampleData
    {
        static IRepository repository { get; set; }
        static SampleData()
        {
            repository = new Repository();
        }

        public static void Initialize()
        {
            if (!repository.Get().Any())
            {
                repository.AddRange(
                    new List<Expense>() {
                        new Expense() { money = 2000, category = Category.Entertainment, create = new DateTime(2015, 2, 1), },
                        new Expense() { money = 200, category = Category.Bill, create = new DateTime(2015, 6, 1), },
                        new Expense() { money = 10, category = Category.Food, create = new DateTime(2015, 6, 1), },
                        new Expense() { money = 20, category = Category.Taxi, create = new DateTime(2015, 7, 1), },
                        new Expense() { money = 200, category = Category.Bill, create = new DateTime(2015, 7, 1), },
                        new Expense() { money = 20, category = Category.Taxi, create = new DateTime(2015, 7, 15), },
                        new Expense() { money = 200, category = Category.Bill, create = new DateTime(2015, 8, 1), },
                        new Expense() { money = 100, category = Category.Food, create = new DateTime(2015, 8, 1), },
                        new Expense() { money = 200, category = Category.Bill, create = new DateTime(2015, 9, 1), },
                        new Expense() { money = 200, category = Category.Bill, create = new DateTime(2015, 10, 1), },
                        new Expense() { money = 200, category = Category.Bill, create = new DateTime(2015, 11, 1), },
                        new Expense() { money = 200, category = Category.Bill, create = new DateTime(2015, 12, 1), },
                        new Expense() { money = 200, category = Category.Bill, create = new DateTime(2016, 1, 1), },
                        new Expense() { money = 100, category = Category.Food, create = new DateTime(2016, 1, 1), }
                    });
            }
        }
    }
}
