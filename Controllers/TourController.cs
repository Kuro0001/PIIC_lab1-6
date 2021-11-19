using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TourController : ControllerBase
    {
        private readonly DBContext _context;
        public TourController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Tour> Get()
        {
            return _context.Tours.ToList();
        }
    }
}
