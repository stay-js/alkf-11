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

static void PrintAllFruits((string, int)[] fruits)
{
    foreach (var fruit in fruits)
    {
        Console.WriteLine($"{fruit.Item1} ({fruit.Item2} kg)");
    }
}

static int SumWeight((string, int)[] fruits)
{
    int sum = 0;

    foreach (var fruit in fruits)
    {
        sum += fruit.Item2;
    }

    return sum;
}

static int CountExactly10Kg((string, int)[] fruits)
{
    int count = 0;

    foreach (var fruit in fruits)
    {
        if (fruit.Item2 == 10) count++;
    }

    return count;
}

static int MostWeight((string, int)[] fruits)
{
    var mostWeight = 0;

    for (int i = 1; i < fruits.Length; i++)
    {
        if (fruits[i].Item2 > fruits[mostWeight].Item2) mostWeight = 1;
    }

    return mostWeight;
}

static void MoreThanOrEqualTo30Kg((string, int)[] fruits)
{
    foreach (var fruit in fruits)
    {
        if (fruit.Item2 >= 30) Console.WriteLine("\t- " + fruit.Item1);
    }
}

static bool FindLessThan10((string, int)[] fruits, out int index)
{
    index = 0;

    while (index < fruits.Length && fruits[index].Item2 >= 10)
    {
        index++;
    }

    return index < fruits.Length;
}