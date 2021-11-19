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
    public class ClientController : ControllerBase
    {
        private readonly DBContext _context;
        public ClientController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _context.Clients.ToList();
        }
    }
}
