using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DeviceController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Device> Get()
        {
            return _context.Devices.ToList();
        }

        [HttpPost]
        public IActionResult Create(Device device)
        {
            if (ModelState.IsValid)
            {
                _context.Devices.Add(device);
                _context.SaveChanges();
                return Ok(device);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Device device)
        {
            if (id != device.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(device);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var device = _context.Devices.Find(id);
            if (device == null)
            {
                return NotFound();
            }

            _context.Devices.Remove(device);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
