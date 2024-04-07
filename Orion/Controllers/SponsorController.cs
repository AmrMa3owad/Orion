using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SponsorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SponsorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Sponsor> Get()
        {
            return _context.Sponsors.ToList();
        }

        [HttpPost]
        public IActionResult Create(Sponsor Sponsor)
        {
            if (ModelState.IsValid)
            {
                _context.Sponsors.Add(Sponsor);
                _context.SaveChanges();
                return Ok(Sponsor);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Sponsor Sponsor)
        {
            if (id != Sponsor.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Sponsor);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Sponsor = _context.Sponsors.Find(id);
            if (Sponsor == null)
            {
                return NotFound();
            }

            _context.Sponsors.Remove(Sponsor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

