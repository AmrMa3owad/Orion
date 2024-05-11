using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orion.Context;
using Orion.Domain.Models;
using Orion.Handlers;
using Orion.Infrastructure.Services;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]

    public class Above12Controller : ControllerBase
    {
        private readonly IAbove12Service _above12Service;

        public Above12Controller(IAbove12Service above12Service)
        {
            _above12Service = above12Service;
        }

        [HttpGet]
        public async Task<List<Above12>> Get()
        {
            List<Above12> bookings = await _above12Service
                .GetAll(new CancellationToken()).ToListAsync();

            return bookings;
        }

        //[HttpPost]
        //public IActionResult Create(Above12 above12)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Above12s.Add(above12);
        //        _context.SaveChanges();
        //        return Ok(above12);
        //    }
        //    return BadRequest(ModelState);
        //}

        //[HttpPut("{id}")]
        //public IActionResult Edit(int id, Above12 above12)
        //{
        //    if (id != above12.Id)
        //    {
        //        return BadRequest();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(above12);
        //        _context.SaveChanges();
        //        return NoContent();
        //    }
        //    return BadRequest(ModelState);
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var above12 = _context.Above12s.Find(id);
        //    if (above12 == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Above12s.Remove(above12);
        //    _context.SaveChanges();
        //    return NoContent();
        //}
    }
}
