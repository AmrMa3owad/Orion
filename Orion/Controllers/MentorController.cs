using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MentorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MentorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Mentor> Get()
        {
            return _context.Mentors.ToList();
        }

        [HttpPost]
        public IActionResult Create(Mentor Mentor)
        {
            if (ModelState.IsValid)
            {
                _context.Mentors.Add(Mentor);
                _context.SaveChanges();
                return Ok(Mentor);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Mentor Mentor)
        {
            if (id != Mentor.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Mentor);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Mentor = _context.Mentors.Find(id);
            if (Mentor == null)
            {
                return NotFound();
            }

            _context.Mentors.Remove(Mentor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
