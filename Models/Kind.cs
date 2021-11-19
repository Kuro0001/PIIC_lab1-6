using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class Kind
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public ICollection<Tour> Tours { get; set; }
        public Kind()
        {
            Tours = new List<Tour>();
        }
    }
}
