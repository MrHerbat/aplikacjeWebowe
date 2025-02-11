using cw10_layout.Models;
using cw10_layout.Models.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace cw10_layout.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameRepo _gamesRepo;
        private readonly string? _connectionString;
        public GamesController(IConfiguration configuration)
        {
            //_studentRepo = new FakeStudentRepo();
            _connectionString = configuration.GetConnectionString("mysql");
            _gamesRepo = new MySqlGameRepo(_connectionString);
        }
        // GET: StudentsController
        public ActionResult List()
        {
            return View(_gamesRepo.GetAllGames());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MyGame game)
        {
            if(ModelState.IsValid){
                _gamesRepo.AddGame(game);
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                _gamesRepo.DeleteGame(id.Value);
            }
            return View();
        }
    }
}