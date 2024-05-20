using System.Globalization;

Console.Write("Adjon meg egy dátumot: ");
var date1 = DateTime.Parse(Console.ReadLine() ?? "", new CultureInfo("hu-HU"));

Console.Write("Adjon meg egy másik dátumot: ");
var date2 = DateTime.Parse(Console.ReadLine() ?? "", new CultureInfo("hu-HU"));

Console.WriteLine();

if (date1 < date2) Console.WriteLine("Az első dátum korábbi.");
else if (date1 > date2) Console.WriteLine("A második dátum korábbi.");
else Console.WriteLine("A két dátum megegyezik.");

Console.WriteLine($"{date1.Year} {(DateTime.IsLeapYear(date1.Year) ? "" : "nem ")}szökőév.");
Console.WriteLine($"{date2.Year} {(DateTime.IsLeapYear(date2.Year) ? "" : "nem ")}szökőév.");

Console.WriteLine($"{date1.ToShortDateString()} => {Season(date1.Month)}");
Console.WriteLine($"{date2.ToShortDateString()} => {Season(date2.Month)}");

static string Season(int month)
{
    return month switch
    {
        12 or <= 2 => "Tél",
        <= 5 => "Tavasz",
        <= 8 => "Nyár",
        <= 11 => "Ősz",
        _ => "Ismeretlen"
    };
}
