namespace ark2_sol.Models;

public class PlayerRepo
{
    private string? _connString;
    public PlayerRepo(IConfiguration configuration)
    {
        _connString = configuration.GetConnectionString("mysql");
    }
}