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
    [HttpGet]
    public IActionResult Index()
    {
        List<Match> matches = _matchesRepo.GetAllMatches();
        ViewBag.Matches = matches;
        ViewBag.Players = new List<Player>();
        return View();
    }
    [HttpPost]
    public IActionResult Index(int id)
    {
        List<Match> matches = _matchesRepo.GetAllMatches();
        List<Player> players = _playerRepo.GetAllFromPosition(id);
        ViewBag.Matches = matches;
        ViewBag.Players = players;
        return View();
    }
    
    public IActionResult AllMatches()
    {
        List<Match> matches = _matchesRepo.GetAllMatches();
        ViewBag.Matches = matches;
        return View();
    }
    

    
}