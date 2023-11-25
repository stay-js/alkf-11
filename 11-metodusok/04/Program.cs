using System.Text;

Console.Write("Adjon meg egy szöveget: ");
Madar(Console.ReadLine() ?? "");

static void Madar(string szoveg)
{
    char[] vowels = ['a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű'];
    var toPrint = new StringBuilder();

    foreach (char ch in szoveg)
    {
        toPrint.Append(vowels.Contains(char.ToLower(ch)) ? $"{ch}v{ch}" : ch);
    }

    Console.WriteLine(toPrint);
}