using MySql.Data.MySqlClient;

namespace ark2_sol.Models;

public class MatchesRepo
{
    private string? _connString;

    public MatchesRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("mysql");
    }

    public List<Match> GetAllMatches()
    {
        List<Match> matches = new ();
        using MySqlConnection conn = new MySqlConnection(_connString);
        using MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM rozgrywka where zespol1='EVG'";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var match = new Match();
            match.Id = reader.GetInt32(0);
            match.Team1 = reader.GetString(1);
            match.Team2 = reader.GetString(2);
            match.Score = reader.GetString(3);
            var date = reader.GetDateTime(4);
            match.Date = date.Date.ToString("yyyy-MM-dd");
            matches.Add(match); 
        }
        conn.Close();
        return matches;
    }
}