using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SponsorAdvertisementController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SponsorAdvertisementController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<SponsorAdvertisement> Get()
        {
            return _context.SponsorAdvertisements.ToList();
        }

        [HttpPost]
        public IActionResult Create(SponsorAdvertisement SponsorAdvertisement)
        {
            if (ModelState.IsValid)
            {
                _context.SponsorAdvertisements.Add(SponsorAdvertisement);
                _context.SaveChanges();
                return Ok(SponsorAdvertisement);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, SponsorAdvertisement SponsorAdvertisement)
        {
            if (id != SponsorAdvertisement.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(SponsorAdvertisement);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var SponsorAdvertisement = _context.SponsorAdvertisements.Find(id);
            if (SponsorAdvertisement == null)
            {
                return NotFound();
            }

            _context.SponsorAdvertisements.Remove(SponsorAdvertisement);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
