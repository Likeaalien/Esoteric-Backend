using Esoteric.Data;
using Esoteric.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Esoteric.Controllers
{
    [ApiController]
    [Route("Leaderboards")]
    public class LeaderboardsController : Controller
    {
        private readonly EsotericContext _context;

        public LeaderboardsController(EsotericContext context)
        {
            _context = context;
        }
        [HttpGet("Player")]
        public async Task<IActionResult> Player()
        {
            var player = await _context.Players.ToListAsync();
            return View(player);
        }

        [HttpPost("PlayerAdd")]
        public async Task<IActionResult> PlayerAdd([FromBody] Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Player received successfully" });
        }
        
    }
}
