
using ConsoleUI;
using System;


Console.WriteLine("Hello World!");
Console.WriteLine(Add(4, 2));

Console.ReadLine();

PersonModel p = new() { Id = 1, FirstName = "Ish", LastName = "Gopu" };

PersonModel p2 = new(2, "krish", "vijay");

PersonModel p3 = null;
if(p3 is null)
{
    Console.WriteLine("The value of p3 is not yet set");
}
else
{
    Console.WriteLine($"Hello {p.FirstName} {p.LastName} ({p.Id})");
}
if(p3 is not null)
{
    Console.WriteLine($"Hello {p.FirstName} {p.LastName} ({p.Id})");
}
p.FirstName = "Iswarya";
Console.WriteLine($"Hello {p.FirstName} {p.LastName} ({p.Id})");
static double Add(double x, double y)
{
    return x + y;
}



