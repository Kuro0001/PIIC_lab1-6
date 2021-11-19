using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal AddedValue { get; set; }
        public decimal Discount { get; set; }



        public ICollection<Tour> Tours { get; set; }
        public Category()
        {
            Tours = new List<Tour>();
        }
    }
}
