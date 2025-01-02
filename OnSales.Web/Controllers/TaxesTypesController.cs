using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnSales.Web.Data;
using OnSales.Web.Data.Entities;

namespace OnSales.Web.Controllers
{
    public class TaxesTypesController : Controller
    {
        private readonly DataContext _context;

        public TaxesTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: TaxesTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TaxeTypes.ToListAsync());
        }

        // GET: TaxesTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxesType = await _context.TaxeTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taxesType == null)
            {
                return NotFound();
            }

            return View(taxesType);
        }

        // GET: TaxesTypes/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( TaxesType taxesType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(taxesType);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "Ya existe un tipo de impuesto con el mismo nombre.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                    }
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }
            return View(taxesType);
        }

        // GET: TaxesTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxesType = await _context.TaxeTypes.FindAsync(id);
            if (taxesType == null)
            {
                return NotFound();
            }
            return View(taxesType);
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  TaxesType taxesType)
        {
            if (id != taxesType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taxesType);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "Ya existe un tipo de impuesto con el mismo nombre.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                    }
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }

            }
            return View(taxesType);
        }

       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taxesType = await _context.TaxeTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (taxesType == null)
            {
                return NotFound();
            }

            return View(taxesType);
        }

  
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taxesType = await _context.TaxeTypes.FindAsync(id);
            if (taxesType != null)
            {
                _context.TaxeTypes.Remove(taxesType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
