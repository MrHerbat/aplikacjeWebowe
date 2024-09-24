namespace cw5.Models;

using cw5.Models;
public class GamesRepo
{
    public static List<Games> GetGames()
    {
        return new List<Games>
        {
            new Games { GameName = "Helldivers 2", GameCost = 189.99f, GameYear = 2024 },
            new Games { GameName = "Minecraft", GameCost = 129.99f, GameYear = 2009 },
            new Games { GameName = "Stardew Valley", GameCost = 53.99f, GameYear = 2016 }
        };
    }
}