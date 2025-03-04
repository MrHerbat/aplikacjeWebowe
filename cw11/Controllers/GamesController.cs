using cw11_layout.Models;
using cw11_layout.Models.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace cw11_layout.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameRepo _gamesRepo;
        private readonly string? _connectionString;

        public GamesController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("mysql");
            _gamesRepo = new MySqlGameRepo(_connectionString);
        }

        public ActionResult GameList()
        {
            return View(_gamesRepo.GetAllGames());
        }
        
        [HttpGet]
        public IActionResult AddGame()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddGame(MyGame game)
        {
            if(ModelState.IsValid){
                _gamesRepo.AddGame(game);
                return RedirectToAction("GameList");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                _gamesRepo.DeleteGame(id.Value);
                return RedirectToAction("GameList");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateGame(int id)
        {
            MyGame game = _gamesRepo.GetGameById(id);
            return View(game);
        }
        
        [HttpPost]
        public IActionResult UpdateGame(MyGame game, int id)
        {
            if(id != null){
                _gamesRepo.UpdateGame(game,id);
                return RedirectToAction("GameList");
            }
            return View();
        }
    }
}