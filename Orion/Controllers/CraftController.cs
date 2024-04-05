using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CraftController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CraftController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Craft> Get()
        {
            return _context.Crafts.ToList();
        }

        [HttpPost]
        public IActionResult Create(Craft Craft)
        {
            if (ModelState.IsValid)
            {
                _context.Crafts.Add(Craft);
                _context.SaveChanges();
                return Ok(Craft);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Craft Craft)
        {
            if (id != Craft.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Craft);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Craft = _context.Crafts.Find(id);
            if (Craft == null)
            {
                return NotFound();
            }

            _context.Crafts.Remove(Craft);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
