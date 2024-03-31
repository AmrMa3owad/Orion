using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdvertisementController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AdvertisementController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Advertisement> Get()
        {
            return _context.Advertisements.ToList();
        }

        [HttpPost]
        public IActionResult Create(Advertisement advertisement)
        {
            if (ModelState.IsValid)
            {
                _context.Advertisements.Add(advertisement);
                _context.SaveChanges();
                return Ok(advertisement);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Advertisement advertisement)
        {
            if (id != advertisement.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(advertisement);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var advertisement = _context.Advertisements.Find(id);
            if (advertisement == null)
            {
                return NotFound();
            }

            _context.Advertisements.Remove(advertisement);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
