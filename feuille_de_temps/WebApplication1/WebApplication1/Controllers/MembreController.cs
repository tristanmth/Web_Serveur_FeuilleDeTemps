using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class MembreController : Controller
{
    private readonly ApplicationDbContext _context;

    public MembreController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var membres = await _context.Membres.ToListAsync();
        return View(membres);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Membre membre)
    {
        if (ModelState.IsValid)
        {
            _context.Add(membre);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(membre);
    }
}
