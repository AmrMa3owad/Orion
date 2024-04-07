using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Domain.Models;

namespace Orion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _context.Employees.ToList();
        }

        [HttpPost]
        public IActionResult Create(Employee Employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(Employee);
                _context.SaveChanges();
                return Ok(Employee);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Employee Employee)
        {
            if (id != Employee.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(Employee);
                _context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Employee = _context.Employees.Find(id);
            if (Employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(Employee);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
