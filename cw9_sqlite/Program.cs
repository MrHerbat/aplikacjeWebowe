using cw9_sqlite.Models;

Product generateProduct()
{
    string? nazwa, typ;
    decimal cena;
    Console.Write("Podaj nazwę: ");
    nazwa = Console.ReadLine();
    Console.Write("Podaj cene: ");
    cena = decimal.Parse(Console.ReadLine());
    Console.Write("Podaj typ: ");
    typ = Console.ReadLine();
    

    return new Product
    {
        Name = nazwa,
        Price = cena,
        Type = typ
    };
}


var repo = new ProductsRepo();
var products = repo.GetProducts();
int idToSearch;
foreach (var product in products)
{
    Console.WriteLine($"{product.Id}\t{product.Name}\t " +
                      $"{product.Price}\t{product.Type}");
}
Console.WriteLine();
Console.Write("Write id to search: ");
idToSearch = Convert.ToInt32(Console.ReadLine());
var findProduct = repo.SearchForProduct(idToSearch);
if (findProduct == null)
{
    Console.WriteLine("No products found");
}
else
{
    Console.WriteLine($"{findProduct.Id}\t{findProduct.Name}\t{findProduct.Price}\t{findProduct.Type}");
}
Product productToAdd = generateProduct();
repo.AddProduct(productToAdd);