﻿Console.Write("Kérem az intevallum alsó határát: ");
int min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Kérem az intevallum felső határát: ");
int max = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("\nAz intervallumba tartozó számok csökkenő sorrendben:");
for (int i = max - 1; i >= min; i--)
{
    Console.Write(i + " ");
}

Console.WriteLine("\n\nAz intervallumba tartozó 5-tel osztható értékek növekvő sorrendben:");
for (int i = min; i < max; i++)
{
    if (i % 5 == 0) Console.WriteLine(i);
}


int amountOfRandomNumbers = Random.Shared.Next(5, 11);
Console.WriteLine($"\n{amountOfRandomNumbers} db véletlen valós érték az intervallumból:");
for (int i = 0; i < amountOfRandomNumbers; i++)
{
    Console.WriteLine((Random.Shared.NextDouble() * (max - min)) + min);
}