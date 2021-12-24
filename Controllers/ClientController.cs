using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("{id}")]
        [Produces("application/xml")]
        public ActionResult<Client> GetClients(int id)
        {
            Client note = _context.Clients.Find(id);
            if (note == null)
            {
                return NotFound();
            }
            return note;
        }
        [HttpPost]
        //[Authorize(Roles = UserRoles.Admin)]
        [Produces("application/xml")]
        public ActionResult Post(Client note)
        {
            if (note.ID == 0)
            {
                _context.Clients.Add(note);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetClients), new { id = note.ID }, note);
            }
            else
            {
                Client studentFromBase = _context.Clients.Find(note.ID);
                if (studentFromBase == null)
                {
                    using (var transaction = _context.Database.BeginTransaction())
                    {
                        _context.Clients.Add(note);
                        _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT DBWebAPIDemo.dbo.Clients ON;");
                        _context.SaveChanges();
                        _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT DBWebAPIDemo.dbo.Clients OFF;");
                        transaction.Commit();
                    }
                    return CreatedAtAction(nameof(GetClients), new { id = note.ID }, note);
                }
                else
                {
                    return BadRequest();
                }
            }
        }

        [HttpPut("{id}")]
        [Produces("application/xml")]
        public ActionResult<Client> Put(int id, Client note)
        {
            if (id != note.ID)
            {
                return BadRequest();
            }

            if (!_context.Clients.Any(s => s.ID == id))
                return NotFound();

            _context.Entry(note).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Client noteFromBase = _context.Clients.Find(id);
            if (noteFromBase != null)
            {
                _context.Clients.Remove(noteFromBase);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status204NoContent);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
