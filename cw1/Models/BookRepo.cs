using System;

namespace cw1.Models;

public class BookRepo
{
    public static List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book{Id=1,Title="W pustyni i w puszczy",Author="Henrk Sienkiewicz",Price=34.99f},
            new Book{Id=2,Title="Eragon",Author="Christopher Paolini",Price=29.99f},
            new Book{Id=3,Title="Pan Tadeusz",Author="Adam Mickiewicz",Price=24.99f},
            new Book{Id=4,Title="Ostatnie Życzenie",Author="Andrzej Sapkowski",Price=34.99f},
            new Book{Id=5,Title="Lalka",Author="Bolesław Prus",Price=19.99f},
        };
    }
}
