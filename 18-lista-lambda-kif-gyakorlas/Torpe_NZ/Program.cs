using Torpe_NZ;

int current = 1;

#region 1. feladat
var data = File
    .ReadAllLines("torpek.txt")
    .Skip(1)
    .Select(line =>
    {
        string[] parts = line.Split(';');

        return new Dwarf(
            parts[0],
            parts[1],
            parts[2] == "F" ? Gender.Male : Gender.Female,
            int.Parse(parts[3]),
            int.Parse(parts[4])
            );
    })
    .ToList();
#endregion

#region 2. feladat
PrintExerciseNumber();
Console.WriteLine($"Az állományban található törpék száma: {data.Count} db");
#endregion

#region 3. feladat
PrintExerciseNumber();
Console.WriteLine($"A törpék átlagos súlya: {data.Average(x => x.Weight):N1} kg");
#endregion

#region 4. feladat
PrintExerciseNumber();
Console.WriteLine("A legmagasabb törpe adatai:");
data.MaxBy(x => x.Height)!.PrintData();
#endregion

#region 5. feladat
PrintExerciseNumber();

Console.Write("A klán neve: ");
string clan = Console.ReadLine() ?? "";

Console.WriteLine((data.Exists(x =>
    string.Equals(x.Clan, clan, StringComparison.CurrentCultureIgnoreCase))
    ? "\tVan" : "\tNincs") + $" {clan} nevű klánba tartozó törpe.");
#endregion

#region 6. feladat
PrintExerciseNumber();
Console.WriteLine($"A legkisebb TTI érték: {data.Min(x => x.BMI):N1}");
#endregion

#region 7. feladat
PrintExerciseNumber();
Console.WriteLine("Nőnemű törpék: " +
    string.Join(", ", data.Where(x => x.Gender == Gender.Female)));
#endregion

#region 8. feladat
PrintExerciseNumber();
Console.WriteLine("Résztvevők:\n\t" +
    string.Join("\n\t", data.OrderBy(x => x.Clan).ThenBy(x => x.Name)));
#endregion

#region 9. feladat
PrintExerciseNumber();
Console.WriteLine("Klánok: " +
    string.Join(", ", data.DistinctBy(x => x.Clan).Select(x => x.Clan)));
#endregion

#region 10. feladat
PrintExerciseNumber();
Console.WriteLine("A 3 legnagyobb TTI-vel rendelkező törpe:\n\t" +
    string.Join("\n\t", data.OrderBy(x => x.BMI).Reverse().Take(3)));
#endregion

#region 11. feladat
PrintExerciseNumber();
Console.WriteLine($"{data.Count(x => x.Gender == Gender.Female)} db nőnemű törpe van.");
#endregion

#region 12. feladat
PrintExerciseNumber();
Console.WriteLine($"A Kova klánba {data.Count(x => x.Clan == "Kova")} db törpe van.");
#endregion

#region 13. feladat
PrintExerciseNumber();
Console.WriteLine("Az Acél klánba " +
    $"{data.Count(x => x is { Clan: "Acél", Gender: Gender.Female })} db nőnemű törpe van.");
#endregion

#region 14. feladat
PrintExerciseNumber();
Console.WriteLine($"A törpék átlagos TTI-je: {data.Average(x => x.BMI):N2}");
#endregion

#region 15. feladat
PrintExerciseNumber();
Console.WriteLine($"A férfi törpék átlagos TTI-je:" +
    $" {data.Where(x => x.Gender == Gender.Male).Average(x => x.BMI):N2}");
#endregion

#region 16. feladat
PrintExerciseNumber();
Console.WriteLine($"A legalacsonyabb TTI-vel rendelkező törpe neve: " +
    data.MinBy(x => x.BMI)!.Name);
#endregion

#region 17. feladat
PrintExerciseNumber();
Console.WriteLine($"A legkönyebb férfi törpe:" +
    $" {data.Where(x => x.Gender == Gender.Male).Min(x => x.Weight)} kg");
#endregion

#region 18. feladat
PrintExerciseNumber();
Console.WriteLine("A legmagasabb nőnemű törpe adatai:");
data.Where(x => x.Gender == Gender.Female).MaxBy(x => x.Height)!.PrintData();
#endregion

#region 19. feladat
PrintExerciseNumber();
Console.WriteLine((data.Exists(x => x.BMI > 40) ? "Létezik" : "Nem létezik") +
    " olyan törpe akonek 40-nél nagyobb a TTI-je");
#endregion

#region 20. feladat
PrintExerciseNumber();
Console.WriteLine((data.Exists(x => x is { Clan: "Kova", Gender: Gender.Female })
    ? "Jött" : "Nem jött") + " női törpe a Kova klánból");
#endregion

#region 21. feladat
PrintExerciseNumber();
Console.WriteLine("A férfi és női törpék számának különbsége: " +
    (data.Count - data.Count(x => x.Gender == Gender.Male)));
#endregion

#region 22. feladat
PrintExerciseNumber();
Console.WriteLine("Résztvevők klánonként magasság szerinti sorrendben:\n\t" +
    string.Join("\n\t", data.OrderBy(x => x.Clan).ThenBy(x => x.Height)));
#endregion

#region 23. feladat
PrintExerciseNumber();
Console.WriteLine("Résztvevők nemenként névsorban:\n\t" +
    string.Join("\n\t", data.OrderBy(x => x.Gender).ThenBy(x => x.Name)));
#endregion

#region 24. feladat
PrintExerciseNumber();
Console.WriteLine(data.DistinctBy(x => x.Weight).Count() +
    " különböző testsúlyú törpe jött el.");
#endregion

#region 25. feladat
PrintExerciseNumber();
Console.WriteLine("Az 5 legalacsonyabb férfi törpe:\n\t" +
    string.Join("\n\t", data.Where(x => x.Gender == Gender.Male).OrderBy(x => x.Height).Take(5)));
#endregion

void PrintExerciseNumber()
{
    Console.Write($"{++current}. feladat: ");
}
