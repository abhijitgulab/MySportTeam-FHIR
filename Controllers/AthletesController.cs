using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MySportTeam.Data;
using MySportTeam.Models;

namespace MySportTeam.Controllers
{
    public class AthletesController : Controller
    {
        private readonly MySportTeamContext _context;

        public AthletesController(MySportTeamContext context)
        {
            _context = context;
        }

       public async Task<IActionResult> Index(string searchString)
        {
            var athlete = from m in _context.Athlete
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                athlete = athlete.Where(s => s.Family.Contains(searchString));
            }

            return View(await athlete.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athlete= await _context.Athlete
                .FirstOrDefaultAsync(m => m.Id == id);
            if (athlete == null)
            {
                return NotFound();
            }

            return View(athlete);
        }
        public async Task<IActionResult> FHIR(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athlete = await _context.Athlete
                .FirstOrDefaultAsync(m => m.Id == id);
            if (athlete == null)
            {
                return NotFound();
            }
            Patient_FHIR pf = new Patient_FHIR();
            pf.Family=athlete.Family;
            pf.Given=athlete.Given;
            pf.Gender=athlete.Gender;
            pf.birthDate=athlete.birthDate;
            pf.Team=athlete.Team;
            pf.Position=athlete.Position;
            pf.Identifier=athlete.Identifier;
            Patient_FHIR_Helper fs=new Patient_FHIR_Helper();
            fs.GetInfo(pf);
            return View(pf);
        }
        public IActionResult Create()
        {
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Family,Given,birthDate,Gender,Identifier,Team,Position")] Athlete athlete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(athlete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(athlete);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athlete = await _context.Athlete.FindAsync(id);
            if (athlete == null)
            {
                return NotFound();
            }
            return View(athlete);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Family,Given,birthDate,Gender,Identifier,Team,Position")] Athlete athlete)
        {
            if (id != athlete.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(athlete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AthleteExists(athlete.Id))
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
            return View(athlete);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athlete = await _context.Athlete
                .FirstOrDefaultAsync(m => m.Id == id);
            if (athlete == null)
            {
                return NotFound();
            }

            return View(athlete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var athlete = await _context.Athlete.FindAsync(id);
            _context.Athlete.Remove(athlete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AthleteExists(int id)
        {
            return _context.Athlete.Any(e => e.Id == id);
        }
    }
}
