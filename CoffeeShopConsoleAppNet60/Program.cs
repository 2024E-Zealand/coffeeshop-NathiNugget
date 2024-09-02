// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
Coffee cortado = new Cortado(5, Blend.Gichathaini);
Coffee latte = new Latte(4, Blend.Bekele); 
Coffee blackcoffee = new BlackCoffee(3, Blend.Aga);
List<Coffee> list = new List<Coffee>(); 
list.Add(latte);
list.Add(blackcoffee);
list.Add(cortado);

List<IHasMilk> coffeeswithmilk = new List<IHasMilk>();
coffeeswithmilk.Add((IHasMilk)cortado); 
coffeeswithmilk.Add((IHasMilk)latte);


foreach (Coffee c in list)
{
    Console.WriteLine($"{c.GetType()}: {c.Price()}DKK {c.Strength()}");
}



foreach (Coffee c in coffeeswithmilk)
{
    Console.WriteLine($"Coffees with milk: {c.GetType()}: {c.Price()}DKK {c.Strength()}");
}