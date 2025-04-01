using MySql.Data.MySqlClient;

namespace ark2_sol.Models;

public class PlayerRepo
{
    private string? _connString;
    public PlayerRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("mysql");
    }

    public List<Player> GetAllFromPosition(int i)
    {
        List<Player> players = new ();
        using MySqlConnection conn = new MySqlConnection(_connString);
        using MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = $"SELECT * FROM zawodnik where pozycja_id={i}";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var player = new Player();
            player.Id = reader.GetInt32(0);
            player.Pozycja_Id = reader.GetInt32(1);
            player.Imie = reader.GetString(2);
            player.Nazwisko = reader.GetString(3);
            players.Add(player);
        }
        conn.Close();
        return players;
    }
}