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
    public class CategoryController : ControllerBase
    {
        private readonly DBContext _context;
        public CategoryController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _context.Categorys.ToList();
        }
    }
}
