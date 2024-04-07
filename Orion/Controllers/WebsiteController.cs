using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebsiteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WebsiteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Website> Get()
        {
            return _context.Websites.ToList();
        }

        [HttpPost]
        public IActionResult Create(Website website)
        {
            if (ModelState.IsValid)
            {
                _context.Websites.Add(website);
                _context.SaveChanges();
                return Ok(website);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Website website)
        {
            if (id != website.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(website);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var website = _context.Websites.Find(id);
            if (website == null)
            {
                return NotFound();
            }

            _context.Websites.Remove(website);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
