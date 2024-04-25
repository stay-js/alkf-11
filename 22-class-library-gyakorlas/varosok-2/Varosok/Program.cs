using Varosok_Lib;

#region 2.feladat
var cities = File.ReadAllLines("varosok.csv").ParseToCities();
#endregion

#region 3.feladat
Console.WriteLine($"3. feladat: Városok száma: {cities.Count()} db");
#endregion

#region 4.feladat
Console.WriteLine($"4. feladat: indiai nagyvárosok lakossága: {cities.PopulationPerCountry("India")} fő");
#endregion

#region 5.feladat
Console.WriteLine("5. feladat: A legnagyobb lakosságú város adatai\n" +
    cities.MaxBy(c => c.Population));
#endregion

#region 6.feladat
Console.WriteLine($"6. feladat: {(cities.ContainsCityFrom("Magyarország") ? "Van" : "Nincs")} " +
    $"magyar város az adatok között");
#endregion

#region 7.feladat
Console.WriteLine($"7. feladat: Kínai városok: {string.Join(", ", cities.CitiesFrom("Kína"))}");
#endregion

#region 8.feladat
Console.Write("8. feladat: ");

double amount;
do Console.Write("Minimum lakosság (millió fő): ");
while (!double.TryParse(Console.ReadLine(), out amount));

Console.WriteLine($"\t{cities.Count(c => c.PopulationInMillions > amount)} olyan város van " +
    $"az adatok között ahol a lakosság eléri a megadott mennyiséget.");
#endregion

#region 9.feladat
Console.WriteLine("9. feladat: Az alábbi országokból található meg város az adatok között: " +
    string.Join("; ", cities.Countries()));
#endregion

#region 10.feladat
cities.WriteTopToFile(5, "otlegnagyobb.txt");
#endregion
