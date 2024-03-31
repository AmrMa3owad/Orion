using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Above12Controller : ControllerBase
    {
        private readonly AppDbContext _context;

        public Above12Controller(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Above12> Get()
        {
            return _context.Above12s.ToList();
        }

        [HttpPost]
        public IActionResult Create(Above12 above12)
        {
            if (ModelState.IsValid)
            {
                _context.Above12s.Add(above12);
                _context.SaveChanges();
                return Ok(above12);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Above12 above12)
        {
            if (id != above12.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(above12);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var above12 = _context.Above12s.Find(id);
            if (above12 == null)
            {
                return NotFound();
            }

            _context.Above12s.Remove(above12);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
