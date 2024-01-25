using Local;

#region a
var data = ReadData();

foreach (var item in data)
{
    Console.WriteLine($"{item.Name}: {item.Invalid} érvénytelen, {item.Valid} érvényes");
}
#endregion

#region b
Console.WriteLine($"\nÖsszesen {data.Sum(x => x.Valid)} érvényes szavazat érkezett.");
#endregion

#region c
Console.WriteLine($"Összesen {data.Sum(x => x.Invalid)} érvénytelen szavazat érkezett.");
#endregion

#region d
var maxVotes = data.MaxBy(x => x.Valid) ?? new Project("John Doe", 0, 0);
Console.WriteLine($"{maxVotes.Name} pályaművére érkezett a legtöbb érvényes szavazat: " +
    $"{maxVotes.Valid} érvényes, {maxVotes.Invalid} érvénytelen szavazatot kapott.");
#endregion

#region e
var moreThan10InvalidVote = MoreThan10InvalidVote();
Console.WriteLine(moreThan10InvalidVote is null
    ? "Nincs olyan pályamű amelyre legalább 10 érvénytelen szavazat érkezett."
    : $"{moreThan10InvalidVote.Name} pályaművére több mint 10 érvénytelen szavazat érkezett.");
#endregion

#region f
Console.WriteLine("\nAz alábbi tanulók kaptak legalább 50 érvényes szavazatot:");
foreach (var item in data.Where(x => x.Valid >= 50))
{
    Console.WriteLine($"{item.Name}: {item.Invalid} érvénytelen, {item.Valid} érvényes");
}

#endregion

static Project[] ReadData()
{
    return File.ReadAllLines("alkoto.txt").Chunk(2).Select(lines =>
    {
        int[] parts = lines[1].Split().Select(int.Parse).ToArray();
        return new Project(lines[0], parts[0], parts[1]);
    }).ToArray();
}

Project? MoreThan10InvalidVote()
{
    var moreThan10InvalidVote = data.Where(x => x.Invalid > 10).ToArray();

    if (moreThan10InvalidVote.Length == 0) return null;
    return moreThan10InvalidVote[0];
}

namespace Local
{
    public record Project(string Name, int Invalid, int Valid);
}