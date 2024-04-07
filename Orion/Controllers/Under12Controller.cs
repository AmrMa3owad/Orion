using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Under12Controller : ControllerBase
    {
        private readonly AppDbContext _context;

        public Under12Controller(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Under12> Get()
        {
            return _context.Under12s.ToList();
        }

        [HttpPost]
        public IActionResult Create(Under12 Under12)
        {
            if (ModelState.IsValid)
            {
                _context.Under12s.Add(Under12);
                _context.SaveChanges();
                return Ok(Under12);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Under12 Under12)
        {
            if (id != Under12.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Under12);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Under12 = _context.Under12s.Find(id);
            if (Under12 == null)
            {
                return NotFound();
            }

            _context.Under12s.Remove(Under12);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
