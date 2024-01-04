using Local;

#region 1.feladat
var data = ReadData();
#endregion

#region 2.feladat
PrintAllFruits();
#endregion

#region 3.feladat
double sum = SumWeight();
Console.WriteLine($"\nA gyümölcsök össztömege: {sum} kg.");
#endregion

#region 4.feladat
Console.WriteLine($"A gyümölcsök átlagos tömege: {sum / data.Length} kg.");
#endregion

#region 5.feladat
Console.WriteLine($"{CountExactly10Kg()} gyümölcsből termett pontosan 10 kg.");
#endregion

#region 6. feladat
var mostWeight = data[MostWeight()];
Console.WriteLine($"{mostWeight.Name}-ból/ből termett a legtöbb ({mostWeight.Weight} kg).");
#endregion

#region 7. feladat
Console.WriteLine("Az alábbi gyűmölcsökből termett legalább 30 kg:");
MoreThanOrEqualTo30Kg();
#endregion

#region 8.feladat
Console.WriteLine(FindLessThan10(out int index)
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

void PrintAllFruits()
{
    foreach (var item in data)
    {
        Console.WriteLine($"{item.Name} ({item.Weight} kg)");
    }
}

int SumWeight()
{
    int sum = 0;

    foreach (var item in data)
    {
        sum += item.Weight;
    }

    return sum;
}

int CountExactly10Kg()
{
    int count = 0;

    foreach (var item in data)
    {
        if (item.Weight == 10) count++;
    }

    return count;
}

int MostWeight()
{
    int mostWeight = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Weight > data[mostWeight].Weight) mostWeight = i;
    }

    return mostWeight;
}

void MoreThanOrEqualTo30Kg()
{
    foreach (var item in data.Where(item => item.Weight >= 30))
    {
        Console.WriteLine("\t- " + item.Weight);
    }
}

bool FindLessThan10(out int index)
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