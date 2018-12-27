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
    public class OrdersController : Controller
    {
        private readonly PDBContext _context;

        public OrdersController(PDBContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var pDBContext = _context.Orders.Include(o => o.Shop).Include(o => o.UserLocation);
            return View(await pDBContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders
                .Include(o => o.Shop)
                .Include(o => o.UserLocation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["ShopId"] = new SelectList(_context.Store, "Id", "Address");
            ViewData["UserLocationId"] = new SelectList(_context.UserLocation, "Id", "Address");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserLocationId,ShopId,OrderTime,TotalDue")] Orders orders)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShopId"] = new SelectList(_context.Store, "Id", "Address", orders.ShopId);
            ViewData["UserLocationId"] = new SelectList(_context.UserLocation, "Id", "Address", orders.UserLocationId);
            return View(orders);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders.FindAsync(id);
            if (orders == null)
            {
                return NotFound();
            }
            ViewData["ShopId"] = new SelectList(_context.Store, "Id", "Address", orders.ShopId);
            ViewData["UserLocationId"] = new SelectList(_context.UserLocation, "Id", "Address", orders.UserLocationId);
            return View(orders);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserLocationId,ShopId,OrderTime,TotalDue")] Orders orders)
        {
            if (id != orders.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersExists(orders.Id))
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
            ViewData["ShopId"] = new SelectList(_context.Store, "Id", "Address", orders.ShopId);
            ViewData["UserLocationId"] = new SelectList(_context.UserLocation, "Id", "Address", orders.UserLocationId);
            return View(orders);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders
                .Include(o => o.Shop)
                .Include(o => o.UserLocation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orders = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(orders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdersExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }

		public async Task<IActionResult> Search(string searchString)
		{//creates linq query
			var orders = from o in _context.Orders
									select o;

			if (!String.IsNullOrEmpty(searchString))
			{//this is  lambda are used in method based linq queries such as where or contains.  delayed execution
				orders = orders.Where(o => o.UserLocation.Equals(searchString));
			}

			return View(await orders.ToListAsync());
		}
	}
}

        //[HttpGet, ActionName("OrderFindAllHistoryLocation")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> OrderFindAllHistoryLocation(UserLocation User)
        //{
        //    //var orders = await _context.Query.locationId == locationId;
        //    var ordersreturn = await _context.UserLocation