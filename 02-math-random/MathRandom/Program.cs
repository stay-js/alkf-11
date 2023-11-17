#region 1. feladat
Console.Write("Adja meg a maximális pontszámot: ");
int maxScore = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ponthatárok:" +
    $"\n\t- elégséges: {Math.Ceiling(maxScore * 0.4)}" +
    $"\n\t- közepes: {Math.Ceiling(maxScore * 0.55)}" +
    $"\n\t- jó: {Math.Ceiling(maxScore * 0.70)}" +
    $"\n\t- jeles: {Math.Ceiling(maxScore * 0.85)}");
#endregion

#region 2. feladat
Console.Write("\nAdjon meg egy minimum értéket: ");
int min = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adjon meg egy maximim értéket: ");
int max = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(Random.Shared.Next(min, max));
}

Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(Random.Shared.NextDouble() * (max - min) + min);
}

Console.ResetColor();
#endregion

#region 3.feladat
Console.Write("\nAdja meg az első pont \"x\" koordinátáját: ");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Adja meg az első pont \"y\" koordinátáját: ");
int y1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg a mádodik pont \"x\" koordinátáját: ");
int x2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Adja meg a második pont \"y\" koordinátáját: ");
int y2 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"A két koordináta távolsága " +
    $"{Math.Sqrt((x1 - x2) * (x1 - x2) + (y2 - y1) * (y2 - y1))}.");
#endregion

#region 4. feladat
Console.Write("\nAdja meg a vásárolt könyvek összértékét: ");
int sum = int.Parse(Console.ReadLine() ?? "");
double salePercent = Random.Shared.Next(0, 50) / 100.0;

Console.WriteLine($"A vásárlónak {sum * (1 - salePercent):C0}" +
    $"-ot kell fizetnie {salePercent:P0} kedvezmény után.");
#endregion

#region 5.feladat
Console.Write("\nAdja meg a kör átmérőjét: ");
double d = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"A kör kerülete: {d * Math.PI}");
Console.WriteLine($"A kör területe: {Math.Pow(d / 2, 2) * Math.PI}");
#endregion

#region 6. feladat
Console.Write("\nAdja meg az osztálylétszámot: ");
Console.WriteLine($"A felelő az osztály" +
    $"{Random.Shared.Next(int.Parse(Console.ReadLine() ?? "")) + 1}. tagja legyen.");
#endregion

#region 7. feladat
Console.Write("\nAdja meg a négyzetlapok számát: ");
int amountOfSquares = int.Parse(Console.ReadLine() ?? "");
double biggestSquareNumber = Math.Floor(Math.Sqrt(amountOfSquares));

Console.WriteLine($"A legnagyobb kirakható négyzet " +
    $"{biggestSquareNumber} * {biggestSquareNumber}, " +
    $"{amountOfSquares - Math.Pow(biggestSquareNumber, 2)} négyzetlap marad.");
#endregion