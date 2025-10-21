using Microsoft.AspNetCore.Mvc;
using BugTrackerAPI.Data;
using BugTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BugsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public BugsController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bug>>> GetBugs()
            => await _context.Bugs
                             .Include(b => b.Project)
                             .Include(b => b.Assignee)
                             .Include(b => b.Creator)
                             .ToListAsync();

        [HttpPost]
        public async Task<ActionResult<Bug>> CreateBug(Bug bug)
        {
            _context.Bugs.Add(bug);
            await _context.SaveChangesAsync();
            return Ok(bug);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBug(int id, Bug updated)
        {
            var bug = await _context.Bugs.FindAsync(id);
            if (bug == null) return NotFound();

            bug.Status = updated.Status;
            bug.Assignee = updated.Assignee;
            bug.Description = updated.Description;

            await _context.SaveChangesAsync();
            return Ok(bug);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBug(int id)
        {
            var bug = await _context.Bugs.FindAsync(id);
            if (bug == null) return NotFound();

            _context.Bugs.Remove(bug);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}