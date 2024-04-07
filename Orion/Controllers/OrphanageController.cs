using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrphanageController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrphanageController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Orphanage> Get()
        {
            return _context.Orphanages.ToList();
        }

        [HttpPost]
        public IActionResult Create(Orphanage Orphanage)
        {
            if (ModelState.IsValid)
            {
                _context.Orphanages.Add(Orphanage);
                _context.SaveChanges();
                return Ok(Orphanage);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Orphanage Orphanage)
        {
            if (id != Orphanage.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Orphanage);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Orphanage = _context.Orphanages.Find(id);
            if (Orphanage == null)
            {
                return NotFound();
            }

            _context.Orphanages.Remove(Orphanage);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
