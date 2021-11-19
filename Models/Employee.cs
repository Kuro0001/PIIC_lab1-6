using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }


        public ICollection<Voucher> Vouchers { get; set; }
        public Employee()
        {
            Vouchers = new List<Voucher>();
        }
    }
}
