using Local;

#region a
var data = ReadData();
#endregion

#region b
foreach (var item in data)
{
    Console.WriteLine($"{item.Name} ({item.Price:C0})");
}
#endregion

#region c
Console.WriteLine($"\nEgy szál virág átlagos ára: {AvgPrice():C2}.");
#endregion

#region d
Console.WriteLine($"A legdrágább virág a(z) {data[MaxPriceIdx()].Name}.");
#endregion

#region e
Console.WriteLine($"{CountAtLeast1000()} db virág kerül legalább 1 000 Ft-ba.");
#endregion

#region f
Console.WriteLine(FindFlower(out int index)
    ? $"A keresett virág ára: {data[index].Price:C0}"
    : "A keresett virág nem található.");
#endregion

static Flower[] ReadData()
{
    return File.ReadAllLines("viragok.txt").Select(line =>
    {
        string[] parts = line.Split(';');
        return new Flower(parts[0], int.Parse(parts[1]));
    }).ToArray();
}

double AvgPrice()
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Price;
    }

    return sum / data.Length;
}

int MaxPriceIdx()
{
    int maxIdx = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Price > data[maxIdx].Price) maxIdx = i;
    }

    return maxIdx;
}

int CountAtLeast1000()
{
    int count = 0;

    foreach (var item in data)
    {
        if (item.Price >= 1000) count++;
    }

    return count;
}

bool FindFlower(out int index)
{
    Console.Write("\nAdja meg a keresett virág nevét: ");
    string name = Console.ReadLine() ?? "";

    index = 0;

    while (index < data.Length
        && !string.Equals(data[index].Name, name, StringComparison.CurrentCultureIgnoreCase))
    {
        index++;
    }

    return index < data.Length;
}

namespace Local
{
    public record Flower(string Name, int Price);
}