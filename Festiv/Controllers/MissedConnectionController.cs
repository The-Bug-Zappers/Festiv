// Controllers/MissedConnectionsController.cs
using Microsoft.AspNetCore.Mvc;
using Festiv.Models;
using Festiv.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

// [Route("PartyDetails/{partyId}/MissedConnection")]
public class MissedConnectionController : Controller
{
    private readonly FestivDbContext _context;

    public MissedConnectionController(FestivDbContext context)
    {
        _context = context;
    }

    [HttpGet("{partyId}")]
    public IActionResult CreatePost(int partyId)
    {
        return View("Views/PartyDetails/CreatePost.cshtml");
    }

    [HttpPost("{partyId}")]
    public async Task<IActionResult> CreatePost(int partyId, MissedConnection model)
    {
        if (ModelState.IsValid)
        {
            _context.MissedConnections.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "PartyDetails", new { partyId = partyId }); 
        }
        return View(model);
    }

    [HttpPost("delete/{partyId}")]
    public async Task<IActionResult> Delete(int id, int partyId)
    {
        var post = await _context.MissedConnections.FindAsync(id);
        if (post != null)
        {
            _context.MissedConnections.Remove(post);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction( "Index", "PartyDetails", new { partyId = partyId }); 
    }
}
