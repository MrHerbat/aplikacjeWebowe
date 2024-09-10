using System;

Console.WriteLine("Hello World!");
cw4();
void cw1()
{   
    Console.WriteLine("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Liczba {a} do kwadratu: {a*a}");
}

void cw2()
{
    try
    {
        Console.WriteLine("Podaj a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        if (b != 0) Console.WriteLine($"{a} / {b} = {(float)a / b}");
        else Console.WriteLine($"{a} / {b}: brak wyniku");
        Console.WriteLine($"{a} / {b} = "+(b!=0?(a/b) : "Brak wyniku"));
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
        throw;
    }
}

void cw3()
{
    Console.WriteLine("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine((a>=0)?$"pierwsiatek liczby {a} wynosi {Math.Sqrt(a)}":"Nie ma ujemnych pierwiastków w liczbach rzeczywistych");
}

void cw4()
{
    //Oblicz pierwiastki trójmianu kwadratowego, gdzie podajemy a,b,c
    Console.WriteLine("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Podaj b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Podaj c: ");
    int c = Convert.ToInt32(Console.ReadLine());
    float delta = (float)Math.Sqrt(b * b - 4 * a * c);
    if (delta == 0) Console.WriteLine($"Jest jedno miejsce zerowe na x={-b/2*a}");
    else if (delta > 0)
        Console.WriteLine($"Są dwa miejsca zerowe na x={(-b - delta) / (2 * a)} oraz x={(-b + delta) / (2 * a)}");
    else Console.WriteLine("Nie ma miejsc zerowych");
}