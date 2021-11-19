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
    public class DirectionController : ControllerBase
    {
        private readonly DBContext _context;
        public DirectionController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Direction> Get()
        {
            return _context.Directions.ToList();
        }
    }
}
