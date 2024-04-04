using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreCommunityController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PreCommunityController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PreCommunity> Get()
        {
            return _context.PreCommunities.ToList();
        }

        [HttpPost]
        public IActionResult Create(PreCommunity PreCommunity)
        {
            if (ModelState.IsValid)
            {
                _context.PreCommunities.Add(PreCommunity);
                _context.SaveChanges();
                return Ok(PreCommunity);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, PreCommunity PreCommunity)
        {
            if (id != PreCommunity.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(PreCommunity);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var PreCommunity = _context.PreCommunities.Find(id);
            if (PreCommunity == null)
            {
                return NotFound();
            }

            _context.PreCommunities.Remove(PreCommunity);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
