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
Console.WriteLine($"{mostWeight.Item1}-ból/ből termett a legtöbb ({mostWeight.Item2} kg).");
#endregion

#region 7. feladat
Console.WriteLine("Az alábbi gyűmölcsökből termett legalább 30 kg:");
MoreThanOrEqualTo30Kg(data);
#endregion

#region 8.feladat
Console.WriteLine(FindLessThan10(data, out int index)
    ? $"{data[index].Item2:C0}-ból/ből termett kevesebb mint 10 kg."
    : "Nem volt olyan gyümölcs amiből kevesebb mint 10 kg termett.");
#endregion

static (string, int)[] ReadData()
{
    return File.ReadLines("gyumolcsok.txt")
        .Select((line) =>
        {
            string[] lineArr = line.Split(';');
            return (lineArr[0], int.Parse(lineArr[1]));
        }).ToArray();
}

static void PrintAllFruits((string, int)[] data)
{
    foreach (var item in data)
    {
        Console.WriteLine($"{item.Item1} ({item.Item2} kg)");
    }
}

static int SumWeight((string, int)[] data)
{
    int sum = 0;

    foreach (var item in data)
    {
        sum += item.Item2;
    }

    return sum;
}

static int CountExactly10Kg((string, int)[] data)
{
    int count = 0;

    foreach (var item in data)
    {
        if (item.Item2 == 10) count++;
    }

    return count;
}

static int MostWeight((string, int)[] data)
{
    var mostWeight = 0;

    for (int i = 1; i < data.Length; i++)
    {
        if (data[i].Item2 > data[mostWeight].Item2) mostWeight = 1;
    }

    return mostWeight;
}

static void MoreThanOrEqualTo30Kg((string, int)[] data)
{
    foreach (var item in data)
    {
        if (item.Item2 >= 30) Console.WriteLine("\t- " + item.Item1);
    }
}

static bool FindLessThan10((string, int)[] data, out int index)
{
    index = 0;

    while (index < data.Length && data[index].Item2 >= 10)
    {
        index++;
    }

    return index < data.Length;
}