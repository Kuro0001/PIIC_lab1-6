using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class TourOperator
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string UniqCompanyNumber { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<Tour> Tours { get; set; }
        public TourOperator()
        {
            Tours = new List<Tour>();
        }
    }
}
