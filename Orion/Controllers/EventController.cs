using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events.ToList();
        }

        [HttpPost]
        public IActionResult Create(Event Event)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(Event);
                _context.SaveChanges();
                return Ok(Event);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Event Event)
        {
            if (id != Event.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Event);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Event = _context.Events.Find(id);
            if (Event == null)
            {
                return NotFound();
            }

            _context.Events.Remove(Event);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
