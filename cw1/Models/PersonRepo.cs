using System;

namespace cw1.Models;

public class PersonRepo
{
    public static List<Person> GetPersons()
    {
        return new List<Person>
        {
            new Person{Id=1,FirstName="Tomasz",LastName="Rączka",Age=15},
            new Person{Id=2,FirstName="Jakub",LastName="Mueller",Age=16},
            new Person{Id=3,FirstName="Karolinka",LastName="Mueller",Age=16},
            new Person{Id=4,FirstName="Chris",LastName="Armatys",Age=17},
            new Person{Id=5,FirstName="Anastazja",LastName="Matys",Age=17},
            new Person{Id=6,FirstName="Mateusz",LastName="Tokaszewicz",Age=17}
        };
    }
}
