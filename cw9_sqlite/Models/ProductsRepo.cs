using System.Globalization;
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

    public Product SearchForProduct(int id)
    {
        Product product;
        using SqliteConnection conn = new SqliteConnection(_connString);
        SqliteCommand command = conn.CreateCommand();
        command.CommandText = "SELECT * FROM products WHERE id = @id";
        command.Parameters.AddWithValue("@id", id);
        conn.Open();
        using SqliteDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
            product = new Product
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Price = reader.GetDecimal(2),
                Type = reader.GetString(3)
            };
            return product;
        }
        else
        {
            return null;
        }
    }

    public void AddProduct(Product product)
    {
        throw new NotImplementedException();
        using SqliteConnection conn = new SqliteConnection(_connString);
        SqliteCommand command = conn.CreateCommand();
        command.CommandText = "INSERT INTO products(name,price,type) VALUES(@name,@price,@type)";
        command.Parameters.AddWithValue("@name", product.Name);
        command.Parameters.AddWithValue("@price", 
            product.Price.ToString(CultureInfo.InvariantCulture));
        command.Parameters.AddWithValue("@type", product.Type);
        conn.Open();
        command.ExecuteNonQuery();
    }
    
}