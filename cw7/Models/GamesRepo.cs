using System;
using System.Text.Json;

namespace cw7.Models;

public class GamesRepo
{
    private string _filePath;
    private List<Game>? _games;

    public GamesRepo(string filePath = "games.json")
    {
        _filePath = filePath;
        string content = File.ReadAllText(_filePath);
        _games = JsonSerializer.Deserialize<List<Game>>(content);
    }
    public List<Game>? Games
    {
        get { return _games; }
    }
    private void SaveChanges()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string content = JsonSerializer.Serialize(_games, options);
        File.WriteAllText(_filePath, content);
    }
    private int GetNextId() //autoincrement
    {
        return _games != null ? _games.Max(m => m.Id) + 1 : 1;
    }

    public Game? GetById(int? id)
    {
        return Games != null ? Games.FirstOrDefault(x => x.Id == id) : null;
    }
    
    public void AddGame(Game game)
    {
        if (_games == null)
        {
            _games = new List<Game>();
        }
        game.Id = GetNextId();
        _games.Add(game);
        SaveChanges();
    }

    public void DeleteGame(Game game)
    {
        if (_games != null)
        {
            return;
        }

        Games?.Remove(game);
        SaveChanges();
    }

    public void EditGame(Game game)
    {
        var gameToEdit = Games.FirstOrDefault(x => x.Id == game.Id);
        if (gameToEdit != null)
        {
            gameToEdit.Title = game.Title;
            gameToEdit.Studio = game.Studio;
            gameToEdit.Genre = game.Genre;
            gameToEdit.Price = game.Price;
            gameToEdit.ReleaseDate = game.ReleaseDate;
            SaveChanges();
        }
    }



}