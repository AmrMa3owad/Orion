using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DeliveryController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Delivery> Get()
        {
            return _context.Deliveries.ToList();
        }

        [HttpPost]
        public IActionResult Create(Delivery Delivery)
        {
            if (ModelState.IsValid)
            {
                _context.Deliveries.Add(Delivery);
                _context.SaveChanges();
                return Ok(Delivery);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Delivery Delivery)
        {
            if (id != Delivery.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Delivery);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Delivery = _context.Deliveries.Find(id);
            if (Delivery == null)
            {
                return NotFound();
            }

            _context.Deliveries.Remove(Delivery);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
