using Microsoft.AspNetCore.Mvc;
using BugTrackerAPI.Data;
using BugTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
            => await _context.Users.ToListAsync();

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(User user)
        {
            var u = await _context.Users.FirstOrDefaultAsync(x =>
                x.Username == user.Username && x.Password == user.Password);

            if (u == null) return Unauthorized("Invalid credentials");
            return Ok(u);
        }
    }
}