using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoothOrderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BoothOrderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<BoothOrder> Get()
        {
            return _context.BoothOrders.ToList();
        }

        [HttpPost]
        public IActionResult Create(BoothOrder BoothOrder)
        {
            if (ModelState.IsValid)
            {
                _context.BoothOrders.Add(BoothOrder);
                _context.SaveChanges();
                return Ok(BoothOrder);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, BoothOrder BoothOrder)
        {
            if (id != BoothOrder.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(BoothOrder);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var BoothOrder = _context.BoothOrders.Find(id);
            if (BoothOrder == null)
            {
                return NotFound();
            }

            _context.BoothOrders.Remove(BoothOrder);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
