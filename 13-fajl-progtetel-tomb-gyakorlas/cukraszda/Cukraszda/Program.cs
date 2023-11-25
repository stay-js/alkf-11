using Local;

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
    $"{mostExpensiveCake.Name} ({mostExpensiveCake.Price:C0})");
#endregion

#region 5.feladat
Console.WriteLine("4500 Ft-nál olcsóbb torták listája: ");
PrintCheaperThanOrEqualTo4500(data);
#endregion

#region 5.feladat
Console.WriteLine(FindCake(data, out int index)
    ? $"A megadott torta megrendelése: {data[index].Price:C0}-ba kerül."
    : "A megadott torta nem található.");
#endregion

static Cake[] ReadData()
{
    return File.ReadLines("tortak.txt")
        .Select(line =>
        {
            string[] lineArr = line.Split(';');
            return new Cake(lineArr[0], int.Parse(lineArr[1]));
        }).ToArray();
}

static void PrintAllCakes(Cake[] data)
{
    foreach (var item in data)
    {
        Console.WriteLine($"{item.Name} ({item.Price:C0})");
    }
}

static double AvgPrice(Cake[] data)
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Price;
    }

    return sum / data.Length;
}

static int MostExpensiveCake(Cake[] data)
{
    int mostExpensive = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Price > data[mostExpensive].Price) mostExpensive = i;
    }

    return mostExpensive;
}

static void PrintCheaperThanOrEqualTo4500(Cake[] data)
{
    foreach (var item in data)
    {
        if (item.Price <= 4500) Console.WriteLine("\t- " + item.Name);
    }
}

static bool FindCake(Cake[] data, out int index)
{
    Console.Write("\nAdja meg egy torta nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < data.Length
        && !data[index].Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < data.Length;
}

namespace Local
{
    public record Cake(string Name, int Price);
}