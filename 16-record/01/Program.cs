using Local;

#region a
var data = ReadData();
#endregion

#region b
var maxScore = data.MaxBy(x => x.Score) ?? new Class("99.zs", 0);
Console.WriteLine($"A legmagasabb pontszámot a {maxScore.Id} osztály érte el: " +
    $"{maxScore.Score} pont.");
#endregion

#region c
Console.WriteLine($"Az átlagos pontszám: {data.Average(x => x.Score)} pont.");
#endregion

#region d
Console.WriteLine($"{data.Count(x => x.Score < 100)} osztály ért el 100-nál kevesebb pontot.");
#endregion

#region e
Console.WriteLine();
int? score = GetScoreById();
Console.WriteLine(score is null
    ? "A keresett osztály nem található."
    : $"A keresett oszály {score} pontot ért el.");
#endregion

#region f
Console.WriteLine("\nAz alábbi osztályok értek el 50-nél kevesebb pontot:\n\t- " +
    string.Join("\n\t- ", data.Where(x => x.Score < 50).Select(x => x.Id)));
#endregion

static Class[] ReadData()
{
    return File.ReadLines("aprilis.txt").Select(line =>
    {
        string[] parts = line.Split(';');
        return new Class(parts[0], int.Parse(parts[1]));
    }).ToArray();
}

int? GetScoreById()
{
    Console.Write("Adja meg a keresett osztály azonosítóját: ");
    string id = Console.ReadLine() ?? "";

    foreach (var item in data)
    {
        if (item.Id == id) return item.Score;
    }

    return null;
}

namespace Local
{
    public record Class(string Id, int Score);
}