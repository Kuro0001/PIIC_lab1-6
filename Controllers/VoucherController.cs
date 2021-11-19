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
    public class VoucherController : ControllerBase
    {
        private readonly DBContext _context;
        public VoucherController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Voucher> Get()
        {
            return _context.Vouchers.ToList();
        }
    }
}
