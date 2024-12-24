using BackendApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace BackendApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminActionsController : ControllerBase
    {
        public SoftwareSalesContext _context;

        public AdminActionsController(SoftwareSalesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdminAction>>> GetAdminActions()
        {
            return await _context.AdminActions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AdminAction>> GetAdminAction(int id)
        {
            var adminAction = await _context.AdminActions.FindAsync(id);
            if (adminAction == null) return NotFound();
            return adminAction;
        }

        [HttpPost]
        public async Task<ActionResult<AdminAction>> CreateAdminAction(AdminAction adminAction)
        {
            _context.AdminActions.Add(adminAction);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAdminAction), new { id = adminAction.ActionId }, adminAction);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAdminAction(int id, AdminAction adminAction)
        {
            if (id != adminAction.ActionId) return BadRequest();
            _context.Entry(adminAction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.AdminActions.Any(e => e.ActionId == id)) return NotFound();
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdminAction(int id)
        {
            var adminAction = await _context.AdminActions.FindAsync(id);
            if (adminAction == null) return NotFound();
            _context.AdminActions.Remove(adminAction);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
