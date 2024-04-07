using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VendorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Vendor> Get()
        {
            return _context.Vendors.ToList();
        }

        [HttpPost]
        public IActionResult Create(Vendor Vendor)
        {
            if (ModelState.IsValid)
            {
                _context.Vendors.Add(Vendor);
                _context.SaveChanges();
                return Ok(Vendor);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Vendor Vendor)
        {
            if (id != Vendor.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Vendor);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Vendor = _context.Vendors.Find(id);
            if (Vendor == null)
            {
                return NotFound();
            }

            _context.Vendors.Remove(Vendor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
