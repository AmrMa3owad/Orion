using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models.Identity;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationUserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserController(
            AppDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<ApplicationUser> Get()
        {
            return _context.Users.ToList();
        }

        [HttpPost]
        public IActionResult Create(ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return Ok(user);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(Guid id, ApplicationUser user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(user);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
