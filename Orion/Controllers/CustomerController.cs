using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.Customers.ToList();
        }

        [HttpPost]
        public IActionResult Create(Customer Customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(Customer);
                _context.SaveChanges();
                return Ok(Customer);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Customer Customer)
        {
            if (id != Customer.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Customer);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Customer = _context.Customers.Find(id);
            if (Customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(Customer);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

