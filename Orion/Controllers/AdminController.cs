using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return _context.Admins.ToList();
        }

        [HttpPost]
        public IActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Admins.Add(admin);
                _context.SaveChanges();
                return Ok(admin);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Admin admin)
        {
            if (id != admin.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(admin);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var admin = _context.Admins.Find(id);
            if (admin == null)
            {
                return NotFound();
            }

            _context.Admins.Remove(admin);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
