using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficeWorkerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OfficeWorkerController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<OfficeWorker> Get()
        {
            return _context.OfficeWorkers.ToList();
        }

        [HttpPost]
        public IActionResult Create(OfficeWorker OfficeWorker)
        {
            if (ModelState.IsValid)
            {
                _context.OfficeWorkers.Add(OfficeWorker);
                _context.SaveChanges();
                return Ok(OfficeWorker);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, OfficeWorker OfficeWorker)
        {
            if (id != OfficeWorker.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(OfficeWorker);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var OfficeWorker = _context.OfficeWorkers.Find(id);
            if (OfficeWorker == null)
            {
                return NotFound();
            }

            _context.OfficeWorkers.Remove(OfficeWorker);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
