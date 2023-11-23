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

static void PrintAllCakes((string, int)[] data)
{
    foreach (var item in data)
    {
        Console.WriteLine($"{item.Item1} ({item.Item2:C0})");
    }
}

static double AvgPrice((string, int)[] data)
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Item2;
    }

    return sum / data.Length;
}

static int MostExpensiveCake((string, int)[] data)
{
    var mostExpensive = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Item2 > data[mostExpensive].Item2) mostExpensive = i;
    }

    return mostExpensive;
}

static void PrintCheaperThanOrEqualTo4500((string, int)[] data)
{
    foreach (var item in data)
    {
        if (item.Item2 <= 4500) Console.WriteLine("\t- " + item.Item1);
    }
}

static bool FindCake((string, int)[] data, out int index)
{
    Console.Write("\nAdja meg egy torta nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < data.Length
        && !data[index].Item1.Equals(name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < data.Length;
}