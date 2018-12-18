using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pf.Models;

namespace Pf.Controllers
{
    public class UserLocationsController : Controller
    {
        private readonly PDBContext _context;

        public UserLocationsController(PDBContext context)
        {
            _context = context;
        }

        // GET: UserLocations
        public async Task<IActionResult> Index()
        {
            var pDBContext = _context.UserLocation.Include(u => u.User);
            return View(await pDBContext.ToListAsync());
        }

        // GET: UserLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLocation = await _context.UserLocation
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userLocation == null)
            {
                return NotFound();
            }

            return View(userLocation);
        }

        // GET: UserLocations/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FirstName");
            return View();
        }

        // POST: UserLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Address,State")] UserLocation userLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FirstName", userLocation.UserId);
            return View(userLocation);
        }

        // GET: UserLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLocation = await _context.UserLocation.FindAsync(id);
            if (userLocation == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FirstName", userLocation.UserId);
            return View(userLocation);
        }

        // POST: UserLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Address,State")] UserLocation userLocation)
        {
            if (id != userLocation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserLocationExists(userLocation.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FirstName", userLocation.UserId);
            return View(userLocation);
        }

        // GET: UserLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLocation = await _context.UserLocation
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userLocation == null)
            {
                return NotFound();
            }

            return View(userLocation);
        }

        // POST: UserLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userLocation = await _context.UserLocation.FindAsync(id);
            _context.UserLocation.Remove(userLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserLocationExists(int id)
        {
            return _context.UserLocation.Any(e => e.Id == id);
        }
    }
}
