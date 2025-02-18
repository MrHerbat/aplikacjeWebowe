namespace cw11_layout.Models.Abstractions;

public interface IGameRepo
{
    List<MyGame> GetAllGames();
    void AddGame(MyGame game);
    void UpdateGame(MyGame game, int id);
    void DeleteGame(int id);
}