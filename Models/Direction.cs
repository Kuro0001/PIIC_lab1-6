using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class Direction
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public ICollection<Hotel> Hotels { get; set; }
        public Direction()
        {
            Hotels = new List<Hotel>();
        }
    }
}
