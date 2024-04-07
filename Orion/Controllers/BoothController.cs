using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoothController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BoothController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Booth> Get()
        {
            return _context.Booths.ToList();
        }

        [HttpPost]
        public IActionResult Create(Booth Booth)
        {
            if (ModelState.IsValid)
            {
                _context.Booths.Add(Booth);
                _context.SaveChanges();
                return Ok(Booth);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Booth Booth)
        {
            if (id != Booth.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Booth);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Booth = _context.Booths.Find(id);
            if (Booth == null)
            {
                return NotFound();
            }

            _context.Booths.Remove(Booth);
            _context.SaveChanges();
            return NoContent();
        }
    }
}