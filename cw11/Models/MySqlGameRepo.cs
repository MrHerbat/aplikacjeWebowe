﻿using System;
using System.Globalization;
using cw11_layout.Models.Abstractions;
using MySql.Data.MySqlClient;

namespace cw11_layout.Models;

public class MySqlGameRepo : IGameRepo
{
    private readonly string? _connectionString;
    public MySqlGameRepo(string? connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddGame(MyGame game)
    {
        using var connection = new MySqlConnection(_connectionString);
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = $"INSERT INTO games(title, genre,studio, price) VALUES " 
            +$"('{game.Title}', '{game.Genre}', '{game.Studio}','{game.Price?.ToString(CultureInfo.InvariantCulture)}')";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public void DeleteGame(int id)
    {
        using var connection = new MySqlConnection(_connectionString);
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = $"DELETE FROM games WHERE id = {id}";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public List<MyGame> GetAllGames()
    {
        using var connection = new MySqlConnection(_connectionString);
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM games";
        connection.Open();
        List<MyGame> games = new List<MyGame>();
        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            games.Add(
                new MyGame()
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Genre = reader.GetString(2),
                    Studio = reader.GetString(3),
                    Price = reader.GetDecimal(4)
                }
            );
        }

        connection.Close();
        return games;
    }

    public void UpdateGame(MyGame game,int id)
    {
        using var connection = new MySqlConnection(_connectionString);
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = $"UPDATE `games` SET title='{game.Title}',studio='{game.Studio}',genre='{game.Genre}',price={game.Price} WHERE id = {{id}}";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}
