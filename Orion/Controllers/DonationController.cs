using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DonationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Donation> Get()
        {
            return _context.Donations.ToList();
        }

        [HttpPost]
        public IActionResult Create(Donation Donation)
        {
            if (ModelState.IsValid)
            {
                _context.Donations.Add(Donation);
                _context.SaveChanges();
                return Ok(Donation);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Donation Donation)
        {
            if (id != Donation.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Donation);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Donation = _context.Donations.Find(id);
            if (Donation == null)
            {
                return NotFound();
            }

            _context.Donations.Remove(Donation);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
