using Microsoft.AspNetCore.Mvc;
using Orion.Context;
using Orion.Models;

namespace YourNamespace.Controllers
{
    public class TestController : Controller
    {
        private readonly AppDbContext _context;

        public TestController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tests = _context.Tests.ToList();
            return View(tests);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Test test)
        {
            if (ModelState.IsValid)
            {
                _context.Tests.Add(test);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(test);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = _context.Tests.Find(id);
            if (test == null)
            {
                return NotFound();
            }
            return View(test);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Test test)
        {
            if (id != test.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(test);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(test);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = _context.Tests.FirstOrDefault(m => m.Id == id);
            if (test == null)
            {
                return NotFound();
            }

            return View(test);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var test = _context.Tests.Find(id);
            _context.Tests.Remove(test);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
