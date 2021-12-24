using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class Tour
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int OffersAll { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public int DayCount { get; set; }
        



        // ==== поля-ключи внешние ====
        public int TourOperatorId { get; set; }
        public int KindId { get; set; }
        public int CategoryId { get; set; }
        public int HotelId { get; set; }


    }
}
