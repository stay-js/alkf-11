Random random = new();

Console.Write("Kérem az intevallum alsó határát: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Kérem az intevallum felső határát: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nAz intervallumba tartozó számok csökkenő sorrendben:");
for (int i = max; i > min; i--) Console.Write(i + " ");

Console.WriteLine("\n\nAz intervallumba tartozó 5-tel osztható értékek növekvő sorrendben:");
for (int i = min; i < max; i++)
{
    if (i % 5 == 0) Console.WriteLine(i);
}


int amountOfRandomNumbers = random.Next(5, 11);
Console.WriteLine($"\n{amountOfRandomNumbers} db véletlen valós érték az intervallumból:");
for (int i = 0; i < amountOfRandomNumbers; i++)
{
    Console.WriteLine(random.NextDouble() * (max - min) + min);
}
