using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerAdvertisementController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerAdvertisementController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<CustomerAdvertisement> Get()
        {
            return _context.CustomerAdvertisements.ToList();
        }

        [HttpPost]
        public IActionResult Create(CustomerAdvertisement CustomerAdvertisement)
        {
            if (ModelState.IsValid)
            {
                _context.CustomerAdvertisements.Add(CustomerAdvertisement);
                _context.SaveChanges();
                return Ok(CustomerAdvertisement);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, CustomerAdvertisement CustomerAdvertisement)
        {
            if (id != CustomerAdvertisement.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(CustomerAdvertisement);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var CustomerAdvertisement = _context.CustomerAdvertisements.Find(id);
            if (CustomerAdvertisement == null)
            {
                return NotFound();
            }

            _context.CustomerAdvertisements.Remove(CustomerAdvertisement);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
