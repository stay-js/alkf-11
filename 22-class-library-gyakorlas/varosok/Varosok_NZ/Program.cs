using Varosok_Lib;

#region 1.feladat
var cities = File.ReadAllLines("varosok.txt").ParseToCityList();
#endregion

#region 2.feladat
Console.WriteLine($"2. feladat: Magyarország {cities.Count} városa szerepel a listában");
#endregion

#region 3.feladat
Console.WriteLine($"3. feladat: Az első 2000 főnél kevesebb lakosú város:\n " +
    cities.FirstLowerThan(2000));
#endregion

#region 4.feladat
Console.WriteLine($"4. feladat: A városok átlagos területe {cities.AvgArea()} km2");
#endregion

#region 5.feladat
Console.WriteLine($"5.feladat: A rendszerváltás után {cities.CountBecameCityLaterThan(1990)}" +
    " település kapott városi rangot");
#endregion

#region 6.feladat
var lowestPopulationDensity = cities.MinBy(c => c.PopulationDensity);
if (lowestPopulationDensity is not null)
{
    Console.Write($"6. feladat: A legkisebb népsűrűségű város: ");
    Console.WriteLine($"{lowestPopulationDensity.Name}\n{lowestPopulationDensity.Info()}");
}
#endregion

#region 7.feladat
Console.Write("7. feladat: ");

uint year;
do Console.Write("A keresett év: ");
while (!uint.TryParse(Console.ReadLine(), out year));

Console.WriteLine(cities.HaveCitiesBeenDeclaredInYear(year)
    ? "\tEbben az évben nyilvánítottak várossá települést"
    : "\tNem volt ebben az évben várossá nyilvánított település");
#endregion

#region 8.feladat
Console.Write("8. feladat: ");
Console.WriteLine(cities.TopCities("Pest", 3));
#endregion

#region 9.feladat
Console.WriteLine("9. feladat: Nógrád vármegyei városok:");
Console.WriteLine(cities.CitiesInCounty("Nógrád"));
#endregion

#region 10.feladat
Console.WriteLine($"10. feladat: Vármegyék városainak száma:\n{cities.AmountOfCitiesPerCounty()}");
#endregion