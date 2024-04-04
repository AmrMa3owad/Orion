using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaterialController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MaterialController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Material> Get()
        {
            return _context.Materials.ToList();
        }

        [HttpPost]
        public IActionResult Create(Material Material)
        {
            if (ModelState.IsValid)
            {
                _context.Materials.Add(Material);
                _context.SaveChanges();
                return Ok(Material);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Material Material)
        {
            if (id != Material.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Material);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Material = _context.Materials.Find(id);
            if (Material == null)
            {
                return NotFound();
            }

            _context.Materials.Remove(Material);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
