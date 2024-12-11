using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class TempsTravailController : Controller
{
    private readonly ApplicationDbContext _context;

    public TempsTravailController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var tempsTravail = await _context.TempsTravail
            .Include(tt => tt.Membre)
            .Include(tt => tt.Sprint)
            .ToListAsync();
        return View(tempsTravail);
    }

    public IActionResult Create()
    {
        ViewBag.Membres = _context.Membres.ToList();
        ViewBag.Sprints = _context.Sprints.ToList();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TempsTravail tempsTravail)
    {
        if (ModelState.IsValid)
        {
            _context.Add(tempsTravail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Membres = _context.Membres.ToList();
        ViewBag.Sprints = _context.Sprints.ToList();
        return View(tempsTravail);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
            return NotFound();

        var tempsTravail = await _context.TempsTravail.FindAsync(id);
        if (tempsTravail == null)
            return NotFound();

        ViewBag.Membres = _context.Membres.ToList();
        ViewBag.Sprints = _context.Sprints.ToList();
        return View(tempsTravail);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, TempsTravail tempsTravail)
    {
        if (id != tempsTravail.Id)
            return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(tempsTravail);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.TempsTravail.Any(e => e.Id == tempsTravail.Id))
                    return NotFound();
                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Membres = _context.Membres.ToList();
        ViewBag.Sprints = _context.Sprints.ToList();
        return View(tempsTravail);
    }
}
