namespace ark2_sol.Models;

public class Player
{
    public int Id { get; set; }
    public int Pozycja_Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string? Pozycja_Nazwa { get; set; }
}