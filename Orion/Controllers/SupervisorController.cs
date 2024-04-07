using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupervisorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SupervisorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Supervisor> Get()
        {
            return _context.Supervisors.ToList();
        }

        [HttpPost]
        public IActionResult Create(Supervisor Supervisor)
        {
            if (ModelState.IsValid)
            {
                _context.Supervisors.Add(Supervisor);
                _context.SaveChanges();
                return Ok(Supervisor);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Supervisor Supervisor)
        {
            if (id != Supervisor.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Supervisor);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Supervisor = _context.Supervisors.Find(id);
            if (Supervisor == null)
            {
                return NotFound();
            }

            _context.Supervisors.Remove(Supervisor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
