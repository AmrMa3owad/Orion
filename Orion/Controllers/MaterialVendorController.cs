using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaterialVendorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MaterialVendorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<MaterialVendor> Get()
        {
            return _context.MaterialVendors.ToList();
        }

        [HttpPost]
        public IActionResult Create(MaterialVendor MaterialVendor)
        {
            if (ModelState.IsValid)
            {
                _context.MaterialVendors.Add(MaterialVendor);
                _context.SaveChanges();
                return Ok(MaterialVendor);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, MaterialVendor MaterialVendor)
        {
            if (id != MaterialVendor.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(MaterialVendor);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var MaterialVendor = _context.MaterialVendors.Find(id);
            if (MaterialVendor == null)
            {
                return NotFound();
            }

            _context.MaterialVendors.Remove(MaterialVendor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
