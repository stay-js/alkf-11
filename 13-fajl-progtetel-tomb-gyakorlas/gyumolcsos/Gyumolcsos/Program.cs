using Local;

#region 1.feladat
var data = ReadData();
#endregion

#region 2.feladat
PrintAllFruits(data);
#endregion

#region 3.feladat
double sum = SumWeight(data);
Console.WriteLine($"\nA gyümölcsök össztömege: {sum} kg.");
#endregion

#region 4.feladat
Console.WriteLine($"A gyümölcsök átlagos tömege: {sum / data.Length} kg.");
#endregion

#region 5.feladat
Console.WriteLine($"{CountExactly10Kg(data)} gyümölcsből termett pontosan 10 kg.");
#endregion

#region 6. feladat
var mostWeight = data[MostWeight(data)];
Console.WriteLine($"{mostWeight.Name}-ból/ből termett a legtöbb ({mostWeight.Weight} kg).");
#endregion

#region 7. feladat
Console.WriteLine("Az alábbi gyűmölcsökből termett legalább 30 kg:");
MoreThanOrEqualTo30Kg(data);
#endregion

#region 8.feladat
Console.WriteLine(FindLessThan10(data, out int index)
    ? $"{data[index].Weight:C0}-ból/ből termett kevesebb mint 10 kg."
    : "Nem volt olyan gyümölcs amiből kevesebb mint 10 kg termett.");
#endregion

static Fruit[] ReadData()
{
    return File.ReadLines("gyumolcsok.txt").Select(line =>
    {
        string[] lineArr = line.Split(';');
        return new Fruit(lineArr[0], int.Parse(lineArr[1]));
    }).ToArray();
}

static void PrintAllFruits(Fruit[] data)
{
    foreach (var item in data)
    {
        Console.WriteLine($"{item.Name} ({item.Weight} kg)");
    }
}

static int SumWeight(Fruit[] data)
{
    int sum = 0;

    foreach (var item in data)
    {
        sum += item.Weight;
    }

    return sum;
}

static int CountExactly10Kg(Fruit[] data)
{
    int count = 0;

    foreach (var item in data)
    {
        if (item.Weight == 10) count++;
    }

    return count;
}

static int MostWeight(Fruit[] data)
{
    int mostWeight = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Weight > data[mostWeight].Weight) mostWeight = i;
    }

    return mostWeight;
}

static void MoreThanOrEqualTo30Kg(Fruit[] data)
{
    foreach (var item in data.Where(item => item.Weight >= 30))
    {
        Console.WriteLine("\t- " + item.Weight);
    }
}

static bool FindLessThan10(Fruit[] data, out int index)
{
    index = 0;

    while (index < data.Length && data[index].Weight >= 10)
    {
        index++;
    }

    return index < data.Length;
}

namespace Local
{
    public record Fruit(string Name, int Weight);
}