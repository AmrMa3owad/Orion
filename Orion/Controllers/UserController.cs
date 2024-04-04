using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }

        [HttpPost]
        public IActionResult Create(User User)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(User);
                _context.SaveChanges();
                return Ok(User);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, User User)
        {
            if (id != User.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(User);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var User = _context.Users.Find(id);
            if (User == null)
            {
                return NotFound();
            }

            _context.Users.Remove(User);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
