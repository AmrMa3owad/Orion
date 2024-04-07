using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _context.Orders.ToList();
        }

        [HttpPost]
        public IActionResult Create(Order Order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(Order);
                _context.SaveChanges();
                return Ok(Order);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Order Order)
        {
            if (id != Order.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Order);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Order = _context.Orders.Find(id);
            if (Order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(Order);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
