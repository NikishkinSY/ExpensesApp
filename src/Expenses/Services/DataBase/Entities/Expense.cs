using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesApp.DataBase
{
    public class Expense
    {
        [Key]
        public int id { get; set; }
        public float money { get; set; }
        public Category category { get; set; }
        public DateTime create { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Category
    {
        Food,
        Bill,
        Taxi,
        Entertainment
    }

}
