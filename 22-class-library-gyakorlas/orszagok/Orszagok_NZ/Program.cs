using Oszagok_Lib;

#region 6. feladat
var countries = Countries.Parse(File.ReadAllLines("orszagok.csv"));
#endregion

#region 7. feladat
Console.WriteLine($"7. feladat: {countries.Count()} ország adatait tároltuk");
#endregion

#region 8. feladat
Console.WriteLine($"8. feladat: Összterület: {countries.SumOfArea():N0} km2, " +
    $"Összlakosság: {countries.SumOfPopulation():N0} fő");
#endregion

#region 9. feladat
Console.WriteLine($"9. feladat: Átlagos távolság Budapesttől: " +
    $"{countries.AvgDistanceFromBudapest():N2} km");
#endregion

#region 10. feladat
Console.WriteLine($"10. feladat: Legnagyobb területű ország: {countries.BiggestCountry()}");
#endregion

#region 11. feladat
Console.WriteLine($"11. feladat: A legkevesebb lakosú ország fővárosa: " +
       $"{countries.CapitalOfLeastPopulatedCountry()}");
#endregion

#region 12. feladat
Console.WriteLine($"12. feladat: A legtávolabbi főváros Budapesttől: " +
       $"{countries.FarthestCapitalFromBudapest()}");
#endregion

#region 13. feladat
Console.WriteLine($"13. feladat: {countries.CountOfStartsWith("A")} " +
    $"db \"A\"-val kezdődő ország adatát tároltuk");
#endregion

#region 14. feladat
Console.Write("14. feladat: Adja meg a keresett fővárost: ");

var country = countries.FindByCapital(Console.ReadLine() ?? "");

if (country is null) Console.WriteLine("\tA megadott főváros nem található");
else Console.WriteLine(country.Info());
#endregion

#region 15. feladat
Console.Write("14. feladat: ");

uint area;
do Console.Write("Maximum terület: ");
while (!uint.TryParse(Console.ReadLine(), out area));

Console.WriteLine("\tA megadott területnél kisebb területű országok: " +
    string.Join(", ", countries.SmallerThan(area)));
#endregion

#region 16. feladat
countries.WriteSmallerThanToFile(93_000, "kisebbMO.txt");
#endregion