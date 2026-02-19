using Esoteric.Data;
using Esoteric.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Esoteric.Controllers
{
    public class LeaderboardsController : Controller
    {
        private readonly EsotericContext _context;

        public LeaderboardsController(EsotericContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Player()
        {
            var player = await _context.Players.ToListAsync();
            return View(player);
        }
    }
}
