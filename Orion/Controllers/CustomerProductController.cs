using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<CustomerProduct> Get()
        {
            return _context.CustomerProducts.ToList();
        }

        [HttpPost]
        public IActionResult Create(CustomerProduct CustomerProduct)
        {
            if (ModelState.IsValid)
            {
                _context.CustomerProducts.Add(CustomerProduct);
                _context.SaveChanges();
                return Ok(CustomerProduct);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, CustomerProduct CustomerProduct)
        {
            if (id != CustomerProduct.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(CustomerProduct);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var CustomerProduct = _context.CustomerProducts.Find(id);
            if (CustomerProduct == null)
            {
                return NotFound();
            }

            _context.CustomerProducts.Remove(CustomerProduct);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
