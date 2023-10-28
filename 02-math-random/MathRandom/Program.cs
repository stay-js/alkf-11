var random = new Random();

#region 1. feladat
Console.Write("Adja meg a maximális pontszámot: ");
int maxScore = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ponthatárok:");
Console.WriteLine($"\t- elégséges: {Math.Ceiling(maxScore * 0.4)}");
Console.WriteLine($"\t- közepes: {Math.Ceiling(maxScore * 0.55)}");
Console.WriteLine($"\t- jó: {Math.Ceiling(maxScore * 0.70)}");
Console.WriteLine($"\t- jeles: {Math.Ceiling(maxScore * 0.85)}");
#endregion

#region 2. feladat
Console.Write("\nAdjon meg egy minimum értéket: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Adjon meg egy maximim értéket: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(random.Next(min, max));
}

Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(random.NextDouble() * (max - min) + min);
}

Console.ResetColor();
#endregion

#region 3.feladat
Console.Write("\nAdja meg az első pont x koordinátáját: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Adja meg az első pont y koordinátáját: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az mádodik pont x koordinátáját: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Adja meg az második pont y koordinátáját: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A két koordináta távolsága " +
    $"{Math.Sqrt((x1 - x2) * (x1 - x2) + (y2 - y1) * (y2 - y1))}.");
#endregion

#region 4. feladat
Console.Write("\nAdja meg a vásárolt könyvek összértékét: ");
int sum = Convert.ToInt32(Console.ReadLine());
int salePercent = random.Next(0, 50);

Console.WriteLine($"A vásárlónak {Math.Round(sum * (100 - salePercent) / 100.0)} " +
    $"Ft-ot kell fizetnie {salePercent}% kedvezmény után.");
#endregion

#region 5.feladat
Console.Write("\nAdja meg a kör átmérőjét: ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A kör kerülete: {d * Math.PI}");
Console.WriteLine($"A kör területe: {Math.Pow(d / 2.0, 2) * Math.PI}");
#endregion

#region 6. feladat
Console.Write("\nAdja meg az osztálylétszámot: ");
int numberOfStudents = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A felelő az osztály {random.Next(numberOfStudents) + 1}. tagja legyen.");
#endregion

#region 7. feladat
Console.Write("\nAdja meg a négyzetlapok számát: ");
int amountOfSquares = Convert.ToInt32(Console.ReadLine());
double biggestSquareNumber = Math.Floor(Math.Sqrt(amountOfSquares));

Console.WriteLine($"A legnagyobb kirakható négyzet " +
    $"{biggestSquareNumber} * {biggestSquareNumber}, " +
    $"{amountOfSquares - Math.Pow(biggestSquareNumber, 2)} négyzetlap marad.");
#endregion