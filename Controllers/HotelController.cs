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
    public class HoteelController : ControllerBase
    {
        private readonly DBContext _context;
        public HoteelController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            return _context.Hotels.ToList();
        }
    }
}
