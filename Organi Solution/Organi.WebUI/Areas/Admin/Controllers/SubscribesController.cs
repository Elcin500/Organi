using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Organi.WebUI.Models.DataContext;
using Organi.WebUI.Models.Entity;

namespace Organi.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscribesController : Controller
    {
        private readonly OrganiDbContext _context;

        public SubscribesController(OrganiDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Subscribes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subscribes.ToListAsync());
        }

        // GET: Admin/Subscribes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscribe = await _context.Subscribes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscribe == null)
            {
                return NotFound();
            }

            return View(subscribe);
        }

        // GET: Admin/Subscribes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Subscribes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email")] Subscribe subscribe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscribe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subscribe);
        }

        // GET: Admin/Subscribes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscribe = await _context.Subscribes.FindAsync(id);
            if (subscribe == null)
            {
                return NotFound();
            }
            return View(subscribe);
        }

        // POST: Admin/Subscribes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email")] Subscribe subscribe)
        {
            if (id != subscribe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subscribe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscribeExists(subscribe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(subscribe);
        }

        // GET: Admin/Subscribes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscribe = await _context.Subscribes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscribe == null)
            {
                return NotFound();
            }

            return View(subscribe);
        }

        // POST: Admin/Subscribes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subscribe = await _context.Subscribes.FindAsync(id);
            _context.Subscribes.Remove(subscribe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscribeExists(int id)
        {
            return _context.Subscribes.Any(e => e.Id == id);
        }
    }
}
