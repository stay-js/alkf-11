using System.Globalization;

Console.Write("Adja meg a születési dátumát: ");
var dateOfBirth = DateTime.Parse(Console.ReadLine() ?? "", new CultureInfo("hu-HU"));

Console.WriteLine($"\t- {Math.Floor((DateTime.UtcNow - dateOfBirth).TotalDays / 365.25)} éves");
Console.WriteLine($"\t- {Math.Floor((DateTime.UtcNow - dateOfBirth).TotalDays)} napos");
Console.WriteLine($"\t- {dateOfBirth.DayOfWeek} napon született");
Console.WriteLine($"\t- Idén {dateOfBirth.AddYears(1).DayOfWeek} napon lesz a születésnapja");
Console.WriteLine($"\t- Csillagjegye: {ZodiacSign()}");

string ZodiacSign()
{
    if (dateOfBirth.Month == 12)
    {
        if (dateOfBirth.Day < 22) return "Nyilas";
        return "Bak";
    }
    else if (dateOfBirth.Month == 1)
    {
        if (dateOfBirth.Day < 20) return "Bak";
        return "Vízöntő";
    }
    else if (dateOfBirth.Month == 2)
    {
        if (dateOfBirth.Day < 19) return "Vízöntő";
        return "Halak";
    }
    else if (dateOfBirth.Month == 3)
    {
        if (dateOfBirth.Day < 21) return "Halak";
        return "Kos";
    }
    else if (dateOfBirth.Month == 4)
    {
        if (dateOfBirth.Day < 20) return "Kos";
        return "Bika";
    }
    else if (dateOfBirth.Month == 5)
    {
        if (dateOfBirth.Day < 21) return "Bika";
        return "Ikrek";
    }
    else if (dateOfBirth.Month == 6)
    {
        if (dateOfBirth.Day < 21) return "Ikrek";
        return "Rák";
    }
    else if (dateOfBirth.Month == 7)
    {
        if (dateOfBirth.Day < 23) return "Rák";
        return "Oroszlán";
    }
    else if (dateOfBirth.Month == 8)
    {
        if (dateOfBirth.Day < 23) return "Oroszlán";
        return "Szűz";
    }
    else if (dateOfBirth.Month == 9)
    {
        if (dateOfBirth.Day < 23) return "Szűz";
        return "Mérleg";
    }
    else if (dateOfBirth.Month == 10)
    {
        if (dateOfBirth.Day < 23) return "Mérleg";
        return "Skorpió";
    }
    else
    {
        if (dateOfBirth.Day < 22) return "Skorpió";
        return "Nyilas";
    }
}
