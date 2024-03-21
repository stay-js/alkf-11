using Sportolok;

var sportolok = new List<Sportolo>();

while (true)
{
    Console.Write("Adja meg az új sportoló nevét (kilépéshez üres enter): ");
    string input = Console.ReadLine() ?? "";
    if (input == "") break;

    sportolok.Add(new Sportolo(input));
}

foreach (var sportolo in sportolok)
{
    Console.WriteLine($"\n{sportolo.Nev} eredményei:");

    while (true)
    {
        Console.Write("Adja meg az eredményt (kilépéshez üres enter): ");
        string input = Console.ReadLine() ?? "";
        if (input == "") break;

        sportolo.UjEredmeny(int.Parse(input));
    }
}

Console.WriteLine($"\n\nSportolók:\n{string.Join('\n', sportolok)}");
Console.WriteLine($"\nVilágrekord: {Sportolo.WR}");
Console.WriteLine($"Rekordtartó: {sportolok.Find(s => s.PB == Sportolo.WR)!.Nev}");