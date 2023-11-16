using System.Text;

Console.Write("Kérem adja meg a felhasználó teljes nevét: ");
string[] name = (Console.ReadLine() ?? "").Trim().Split(' ');

Console.Write("Kérem adja meg a felhasználó osztályát: ");
string schoolClass = (Console.ReadLine() ?? "").Trim();

var toPrint = new StringBuilder();

toPrint.Append(char.ToUpper(schoolClass[^1]));
toPrint.Append(Random.Shared.Next(100, 1000));
toPrint.Append(new[] { '?', '!', '%' }[Random.Shared.Next(3)]);
toPrint.Append(name[0][..3]);

for (int i = 0; i < name[^1].Length; i++)
{
    if (i % 2 == 0) toPrint.Append(name[^1][i]);
}

Console.WriteLine($"Az elkészült jelszó: {toPrint}");
