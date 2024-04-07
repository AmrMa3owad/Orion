using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PaymentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Payment> Get()
        {
            return _context.Payments.ToList();
        }

        [HttpPost]
        public IActionResult Create(Payment Payment)
        {
            if (ModelState.IsValid)
            {
                _context.Payments.Add(Payment);
                _context.SaveChanges();
                return Ok(Payment);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Payment Payment)
        {
            if (id != Payment.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Payment);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Payment = _context.Payments.Find(id);
            if (Payment == null)
            {
                return NotFound();
            }

            _context.Payments.Remove(Payment);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
