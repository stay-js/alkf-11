#region 1.feladat
var data = ReadData();
#endregion

#region 2.feladat
PrintAllCakes(data);
#endregion

#region 3.feladat
Console.WriteLine($"\nA torták átlagos ára: {AvgPrice(data):C0}.");
#endregion

#region 4.feladat
var mostExpensiveCake = data[MostExpensiveCake(data)];
Console.WriteLine($"A legdrágább torta: " +
    $"{mostExpensiveCake.Item1} ({mostExpensiveCake.Item2:C0})");
#endregion

#region 5.feladat
Console.WriteLine("4500 Ft-nál olcsóbb torták listája: ");
PrintCheaperThanOrEqualTo4500(data);
#endregion

#region 5.feladat
Console.WriteLine(FindCake(data, out int index)
    ? $"A megadott torta megrendelése: {data[index].Item2:C0}-ba kerül."
    : "A megadott torta nem található.");
#endregion

static (string, int)[] ReadData()
{
    return File.ReadLines("tortak.txt")
        .Select((line) =>
        {
            string[] lineArr = line.Split(';');
            return (lineArr[0], int.Parse(lineArr[1]));
        }).ToArray();
}

static void PrintAllCakes((string, int)[] cakes)
{
    foreach (var cake in cakes)
    {
        Console.WriteLine($"{cake.Item1} ({cake.Item2:C0})");
    }
}

static double AvgPrice((string, int)[] cakes)
{
    double sum = 0;

    foreach (var cake in cakes)
    {
        sum += cake.Item2;
    }

    return sum / cakes.Length;
}

static int MostExpensiveCake((string, int)[] cakes)
{
    var mostExpensive = 0;

    for (int i = 1; i < cakes.Length; i++)
    {
        if (cakes[i].Item2 > cakes[mostExpensive].Item2) mostExpensive = 1;
    }

    return mostExpensive;
}

static void PrintCheaperThanOrEqualTo4500((string, int)[] cakes)
{
    foreach (var cake in cakes)
    {
        if (cake.Item2 <= 4500) Console.WriteLine("\t- " + cake.Item1);
    }
}

static bool FindCake((string, int)[] cakes, out int index)
{
    Console.Write("\nAdja meg egy torta nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < cakes.Length
        && !cakes[index].Item1.Equals(name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < cakes.Length;
}