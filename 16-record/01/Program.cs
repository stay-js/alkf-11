using Local;

#region a
var data = ReadData();
#endregion

#region b
var maxScore = data[MaxScore()];
Console.WriteLine($"A legmadasabb pontszámot a {maxScore.Id} osztály érte el: " +
                  $"{maxScore.Score} pont.");
#endregion

#region c
Console.WriteLine($"Az átlagos pontszám: {AvgScore()} pont.");
#endregion

#region d
Console.WriteLine($"{CountLessThan100()} osztály ért el 100-nál kevesebb pontot.");
#endregion

#region e
Console.WriteLine();
Console.WriteLine(GetScore(out int score)
    ? $"A keresett oszály {score} pontot ért el."
    : "A keresett osztály nem található.");
#endregion

#region f
Console.WriteLine("\nAz alábbi osztályok értek el 50-nél kevesebb pontot:\n\t- " +
                  string.Join("\n\t- ", SelectLessThen50().Select(x => x.Id)));
#endregion

static Class[] ReadData()
{
    return File.ReadLines("aprilis.txt").Select(line =>
    {
        string[] parts = line.Split(';');
        return new Class(parts[0], int.Parse(parts[1]));
    }).ToArray();
}

int MaxScore()
{
    int max = 0;

    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Score > data[max].Score) max = i;
    }

    return max;
}

double AvgScore()
{
    double sum = 0;

    foreach (var item in data)
    {
        sum += item.Score;
    }

    return sum / data.Length;
}

int CountLessThan100()
{
    int count = 0;

    foreach (var item in data.Where(x => x.Score < 100))
    {
        count++;
    }

    return count;
}

bool GetScore(out int score)
{
    Console.Write("Adja meg a keresett osztály azonosítóját: ");
    string id = Console.ReadLine() ?? "";

    score = -1;

    foreach (var item in data)
    {
        if (item.Id != id) continue;

        score = item.Score;
        return true;
    }

    return false;
}

Class[] SelectLessThen50()
{
    var lessThan50 = new Class[data.Length];
    int len = 0;

    foreach (var item in data.Where(x => x.Score < 50))
    {
        lessThan50[len++] = item;
    }

    Array.Resize(ref lessThan50, len);

    return lessThan50;
}

namespace Local
{
    public record Class(string Id, int Score);
}