using Snooker_Lib;

#region 1.feladat
var competitors = Competitors.Parse(File.ReadAllLines("snooker.txt"));
#endregion

#region 2.feladat
Console.WriteLine($"2. feladat: A világranglistán {competitors.Count()} versenyző szerepel");
#endregion

#region 3.feladat
Console.WriteLine($"3. feladat: Az első helyen áll:\n{competitors.FirstPlace()}");
#endregion

#region 4.feladat
Console.WriteLine($"4. feladat: {competitors.CountFirstNameStartsWith("A")}" +
    " versenyzőnek kezdődik \"A\" betűvel a vezetékneve.");
#endregion

#region 5.feladat
Console.WriteLine($"5. feladat: A versenyzők átlagosan {competitors.AvgAward():F2}" +
    " fontot kerestek");
#endregion

#region 6.feladat
Console.WriteLine($"6. feladat: {competitors.CountNotFrom("Anglia")}" +
    " versenyző nem Anglia színeiben indul");
#endregion

#region 7.feladat
Console.WriteLine("7. feladat: A legjobban kereső kínai versenyző:\n" +
    competitors.HighestPaidFrom("Kína")?.InfoWithAwardInHuf());
#endregion

#region 8.feladat
Console.Write("8. feladat: A versenyző országa: ");
string country = Console.ReadLine() ?? "";

Console.WriteLine($"\t{(competitors.ExistsFrom(country) ? "Van" : "Nincs")} {country}" +
    " színeiben induló versnyző");
#endregion

#region 9.feladat
Console.WriteLine("9. feladat: A 3 legelőkelőbb helyen álló angol versenyző:\n\t" +
    string.Join("\n\t", competitors.TopFrom(3, "Anglia")));
#endregion

#region 10.feladat
Console.WriteLine($"10. feladat: Országok nevei: {string.Join(", ", competitors.Countries())}");
#endregion

#region 11.feladat
Console.WriteLine($"11. feladat: Skócia színeiben induló versenyzők: " +
    string.Join(", ", competitors.CompetitorsFrom("Skócia")));
#endregion
