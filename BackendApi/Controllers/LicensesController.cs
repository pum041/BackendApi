using BackendApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackendApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LicensesController : ControllerBase
    {
        public SoftwareSalesContext _context;

        public LicensesController(SoftwareSalesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<License>>> GetLicenses()
        {
            return await _context.Licenses.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<License>> GetLicense(int id)
        {
            var license = await _context.Licenses.FindAsync(id);
            if (license == null) return NotFound();
            return license;
        }

        [HttpPost]
        public async Task<ActionResult<License>> CreateLicense(License license)
        {
            _context.Licenses.Add(license);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLicense), new { id = license.LicenseId }, license);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLicense(int id, License license)
        {
            if (id != license.LicenseId) return BadRequest();
            _context.Entry(license).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Licenses.Any(e => e.LicenseId == id)) return NotFound();
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLicense(int id)
        {
            var license = await _context.Licenses.FindAsync(id);
            if (license == null) return NotFound();
            _context.Licenses.Remove(license);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
