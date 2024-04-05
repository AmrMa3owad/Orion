using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryOrderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DeliveryOrderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<DeliveryOrder> Get()
        {
            return _context.DeliveryOrders.ToList();
        }

        [HttpPost]
        public IActionResult Create(DeliveryOrder DeliveryOrder)
        {
            if (ModelState.IsValid)
            {
                _context.DeliveryOrders.Add(DeliveryOrder);
                _context.SaveChanges();
                return Ok(DeliveryOrder);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, DeliveryOrder DeliveryOrder)
        {
            if (id != DeliveryOrder.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(DeliveryOrder);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var DeliveryOrder = _context.DeliveryOrders.Find(id);
            if (DeliveryOrder == null)
            {
                return NotFound();
            }

            _context.DeliveryOrders.Remove(DeliveryOrder);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
