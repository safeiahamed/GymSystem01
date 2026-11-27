using GymSystem.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.Controllers
{
    public class PlanController : Controller
    {
        private GymDbContext context = new();
        public async Task<IActionResult> Index()
        {
            var plans=await context.Plans.ToListAsync();
            return View(plans);
        }
    }
}
