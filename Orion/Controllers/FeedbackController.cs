using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FeedbackController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Feedback> Get()
        {
            return _context.Feedbacks.ToList();
        }

        [HttpPost]
        public IActionResult Create(Feedback Feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Feedbacks.Add(Feedback);
                _context.SaveChanges();
                return Ok(Feedback);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Feedback Feedback)
        {
            if (id != Feedback.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Feedback);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Feedback = _context.Feedbacks.Find(id);
            if (Feedback == null)
            {
                return NotFound();
            }

            _context.Feedbacks.Remove(Feedback);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
