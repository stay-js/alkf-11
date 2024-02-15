const int SPOTS = 40;

#region 1. feladat
var applicants = File.ReadLines("jelentkezok.txt").ToList();
Console.WriteLine($"Jelentkezők listája:\n{string.Join("\n", applicants)}");
#endregion

#region 2. feladat
var accepted = applicants.Take(SPOTS).ToList();
accepted.Sort();

Console.WriteLine($"\nElfogadottak listája:\n{string.Join("\n", accepted)}");
#endregion

#region 3. feladat
Console.WriteLine($"\nHelyhiány miatt elutasítottak listája:\n" +
    string.Join("\n", applicants.Except(accepted)));
#endregion

#region 4. feladat
var failed = File.ReadLines("bukott.txt").ToList();

var removedDueToFailing = applicants.Intersect(failed).ToList();
removedDueToFailing.Sort();

accepted.RemoveAll(removedDueToFailing.Contains);

Console.WriteLine($"\n{removedDueToFailing.Count} diákot kellett utólag törölni.");
File.WriteAllLines("torolt.txt", removedDueToFailing);
#endregion

#region 5. feladat
var toBeAccepted = applicants
    .Except(removedDueToFailing)
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

if (!applicants.Contains(name)) Console.WriteLine("Nem jelentkezett.");
else if (accepted.Contains(name)) Console.WriteLine("Részt vehet a kiránduláson.");
else if (removedDueToFailing.Contains(name)) Console.WriteLine("Bukás miatt elutasítva.");
else Console.WriteLine("Helyhiány miatt elutasítva.");
#endregion