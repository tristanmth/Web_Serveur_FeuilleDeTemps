using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class SprintController : Controller
{
    private readonly ApplicationDbContext _context;

    public SprintController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var sprints = await _context.Sprints.ToListAsync();
        return View(sprints);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Sprint sprint)
    {
        if (ModelState.IsValid)
        {
            _context.Add(sprint);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(sprint);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
            return NotFound();

        var sprint = await _context.Sprints
            .Include(s => s.Membres)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (sprint == null)
            return NotFound();

        return View(sprint);
    }
}
