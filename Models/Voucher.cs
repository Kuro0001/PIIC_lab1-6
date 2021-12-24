using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class Voucher
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }





        // ==== поля-ключи внешние ====
        public int EmployeeId { get; set; }
        public int TourId { get; set; }
        public int ClientId { get; set; }
    }
}
