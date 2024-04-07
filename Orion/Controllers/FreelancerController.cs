using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FreelancerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FreelancerController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Freelancer> Get()
        {
            return _context.Freelancers.ToList();
        }

        [HttpPost]
        public IActionResult Create(Freelancer Freelancer)
        {
            if (ModelState.IsValid)
            {
                _context.Freelancers.Add(Freelancer);
                _context.SaveChanges();
                return Ok(Freelancer);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Freelancer Freelancer)
        {
            if (id != Freelancer.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Freelancer);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Freelancer = _context.Freelancers.Find(id);
            if (Freelancer == null)
            {
                return NotFound();
            }

            _context.Freelancers.Remove(Freelancer);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
