﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcDoll.Data;
using MvcDoll.Models;

namespace MvcDoll.Controllers
{
    public class DollsController : Controller
    {
        private readonly MvcDollContext _context;

        public DollsController(MvcDollContext context)
        {
            _context = context;
        }

        // GET: Dolls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Doll.ToListAsync());
        }

        // GET: Dolls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doll = await _context.Doll
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doll == null)
            {
                return NotFound();
            }

            return View(doll);
        }

        // GET: Dolls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dolls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,LaunchDate,Color,Price")] Doll doll)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doll);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doll);
        }

        // GET: Dolls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doll = await _context.Doll.FindAsync(id);
            if (doll == null)
            {
                return NotFound();
            }
            return View(doll);
        }

        // POST: Dolls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,LaunchDate,Color,Price")] Doll doll)
        {
            if (id != doll.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doll);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DollExists(doll.Id))
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
            return View(doll);
        }

        // GET: Dolls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doll = await _context.Doll
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doll == null)
            {
                return NotFound();
            }

            return View(doll);
        }

        // POST: Dolls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doll = await _context.Doll.FindAsync(id);
            _context.Doll.Remove(doll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DollExists(int id)
        {
            return _context.Doll.Any(e => e.Id == id);
        }
    }
}
