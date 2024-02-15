const int SPOTS = 40;

#region 1. feladat
var entries = File.ReadLines("jelentkezok.txt").ToList();
Console.WriteLine($"Jelentkezők listája:\n{string.Join("\n", entries)}");
#endregion

#region 2. feladat
var accepted = entries.Take(SPOTS).ToList();
accepted.Sort();

Console.WriteLine($"\nElfogadottak listája:\n{string.Join("\n", accepted)}");
#endregion

#region 3. feladat
var rejected = entries.Except(accepted);
Console.WriteLine($"\nHelyhiány miatt elutasítottak listája:\n{string.Join("\n", rejected)}");
#endregion

#region 4. feladat
var failed = File.ReadLines("bukott.txt").ToList();

var toBeRemoved = entries.Intersect(failed).ToList();
toBeRemoved.Sort();

Console.WriteLine($"\n{toBeRemoved.Count} diákot kellett utólag törölni.");
File.WriteAllLines("torolt.txt", toBeRemoved);

accepted = accepted.Except(toBeRemoved).ToList();
#endregion

#region 5. feladat
var toBeAccepted = entries
    .Except(toBeRemoved)
    .Except(accepted)
    .Take(SPOTS - accepted.Count);

accepted.AddRange(toBeAccepted);
accepted.Sort();

Console.WriteLine($"\nRésztvevők listája:\n{string.Join("\n", accepted)}");
File.WriteAllLines("resztvevok.txt", accepted);
#endregion

#region 6. feladat
Console.Write("\nAdja meg a keresett nevet: ");
string name = Console.ReadLine() ?? "";

if (!entries.Contains(name)) Console.WriteLine("Nem jelentkezett.");
else if (accepted.Contains(name)) Console.WriteLine("Részt vehet a kiránduláson.");
else if (toBeRemoved.Contains(name)) Console.WriteLine("Bukás miatt elutasítva.");
else Console.WriteLine("Helyhiány miatt elutasítva.");
#endregion