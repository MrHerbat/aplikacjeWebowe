using Microsoft.Data.Sqlite;

namespace cw9_sqlite.Models;

public class ProductsRepo
{
    private readonly string? _connString;

    public ProductsRepo()
    {
        _connString = "Data Source=productsDb.db";
    }

    public List<Product> GetProducts()
    {
        List<Product> products = new List<Product>();
        using SqliteConnection conn = new SqliteConnection(_connString);
        SqliteCommand command = conn.CreateCommand();
        command.CommandText = "SELECT * FROM products";
        conn.Open();
        using SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            products.Add(
                new Product
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetDecimal(2),
                    Type = reader.GetString(3)
                }
                );
        }
        
        return products;
    }
    
}