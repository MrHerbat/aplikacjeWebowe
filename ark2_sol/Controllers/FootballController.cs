using ark2_sol.Models;
using Microsoft.AspNetCore.Mvc;

namespace ark2_sol.Controllers;

public class FootballController : Controller
{
    private PlayerRepo _playerRepo;
    private MatchesRepo _matchesRepo;
    
    public FootballController(IConfiguration configuration)
    {
        _playerRepo = new PlayerRepo(configuration);
        _matchesRepo = new MatchesRepo(configuration);
        
    }
    
    public IActionResult Index()
    {
        List<Match> matches = _matchesRepo.GetAllMatches();
        return View(matches);
    }
}