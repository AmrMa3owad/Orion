using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _context.Products.ToList();
        }

        [HttpPost]
        public IActionResult Create(Product Product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(Product);
                _context.SaveChanges();
                return Ok(Product);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Product Product)
        {
            if (id != Product.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Product);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Product = _context.Products.Find(id);
            if (Product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(Product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
