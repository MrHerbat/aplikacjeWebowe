using MySql.Data.MySqlClient;

namespace makarony.Models;

public class RepoReservation
{ 
    
    private string _connectionString;
    public RepoReservation(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public void SaveToDb(Reservation reservation)
    {
        using MySqlConnection conn = new MySqlConnection(_connectionString);
        using MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO rezerwacje (nr_stolika,data_rez,liczba_osob,telefon) VALUES " +
                          $"({reservation.Place},{reservation.Date},{reservation.Count},{reservation.Phone})";
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    public List<Reservation> GetAllResevations()
    {
        List<Reservation> reservations = new List<Reservation>();
        using MySqlConnection conn = new MySqlConnection(_connectionString);
        using MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM rezerwacje";
        conn.Open();
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var reservation = new Reservation();
            reservation.Id = reader.GetInt32(0);
            reservation.Place = reader.GetInt32(1);
            var date = reader.GetDateTime(2);
            reservation.Date = date.ToString("yyyy-MM-dd");
            reservation.Count = reader.GetInt32(3);
            reservation.Phone = reader.GetString(4);
            reservations.Add(reservation);
        }
        conn.Close();
        return reservations;
    }
}