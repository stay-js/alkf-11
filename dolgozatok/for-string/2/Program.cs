Random random = new();

Console.Write("Kérem adja meg a felhasználó teljes nevét: ");
string fullName = (Console.ReadLine() ?? "").Trim();
string[] nameAsArray = fullName.Split(' ');

Console.Write("Kérem adja meg a felhasználó osztályát: ");
string schoolClass = (Console.ReadLine() ?? "").Trim();

string password = "";

password += char.ToUpper(schoolClass[^1]);
password += random.Next(100, 1000);
password += new[] { '?', '!', '%' }[random.Next(3)];
password += fullName[..3];

for (int i = 0; i < nameAsArray[^1].Length; i++)
{
    if (i % 2 == 0) password += nameAsArray[^1][i];
}

Console.WriteLine($"Az elkészült jelszó: {password}");
