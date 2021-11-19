using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public String Passport { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }

        // ==== поля-ключи внешние ====
        public ICollection<Voucher> Vouchers { get; set; }
        public Client()
        {
            Vouchers = new List<Voucher>();
        }
    }
}
