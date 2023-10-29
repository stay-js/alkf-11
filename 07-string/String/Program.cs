using System.Text;
using System.Text.RegularExpressions;


var random = new Random();

#region 1.feladat
Console.Write("Adjon meg egy szöveget: ");
string str = Console.ReadLine() ?? "";

// a.
Console.WriteLine($"A szöveg hossza: {str.Length}");

//b.
foreach (char ch in str)
{
    Console.WriteLine(ch);
}

//c.
for (int i = str.Length - 1; i >= 0; i--)
{
    Console.WriteLine(str[i]);
}

//d.
Console.WriteLine(str.ToUpper());

//e.
Console.WriteLine(str.ToLower());

//f.
Console.Write("\nAdjon meg egy szót, amely legalább 3 betűből áll: ");
string word = Console.ReadLine() ?? "";

Console.WriteLine(word[0] +
    string.Concat(word[1..^1].OrderBy(_ => random.Next())) +
    word[^1]);
#endregion

#region 2.feladat
Console.Write("\nAdjon meg egy szót: ");
string word1 = Console.ReadLine() ?? "";

Console.Write("Adjon meg egy szót: ");
string word2 = Console.ReadLine() ?? "";

//a.
Console.WriteLine(word1 + word2);

//b.
if (word1.Length == word2.Length)
    Console.WriteLine("A két szó hossza megegyezik.");
else
    Console.WriteLine($"{(word1.Length > word2.Length ? "Az első" : "A második")}" +
        $"szó a hosszabb.");

//c.
Console.WriteLine($"{word1};{word2}");

//d.
Console.WriteLine(word1 + string.Concat(word2.Reverse()));

//e.
var toPrint = new StringBuilder();

for (int i = 0; i < (word1.Length > word2.Length ? word1.Length : word2.Length); i++)
{
    if (i % 2 == 0)
        toPrint.Append(i >= word2.Length ? '*' : word2[i]);
    else
        toPrint.Append(i >= word1.Length ? '*' : word1[i]);

}
Console.WriteLine(toPrint);
#endregion

#region 3. feladat
Console.Write("\nAdjon meg egy szöveget: ");
string str2 = Console.ReadLine() ?? "";

//a.
Console.WriteLine(string.Concat(str2.Reverse()));

//b.
Console.WriteLine(str2.Replace("  ", " "));

//c.
Console.WriteLine(str2.Trim());

//d.
string lowerTrimmedStr2 = str2.Trim().ToLower();
Console.WriteLine($"A szó" +
    $"{(lowerTrimmedStr2 != string.Concat(lowerTrimmedStr2.Reverse()) ? " nem " : " ")}" +
    $"palindrom.");

//e.
toPrint.Clear();

foreach (char ch in str2)
{
    toPrint.Append(char.IsLower(ch)? char.ToUpper(ch) : char.ToLower(ch));
}

Console.WriteLine(toPrint);
#endregion

#region 4.feladat
Console.Write("\nAdja meg a teljes nevét: ");
string[] name = (Console.ReadLine() ?? "").Split(" ");

//a.
Console.WriteLine(string.Join('.', name).ToLower());

//b.
toPrint.Clear();

//i.
toPrint.Append(name[0][..2].ToLower());

//ii.
for (int i = 0; i < 3; i++) 
{
     toPrint.Append(random.Next(0, 10));
}

//iii.
for (int i = 0; i < name[1].Length; i++) 
{
     if (i % 2 != 0) toPrint.Append(name[1][i]);
}

//iv.
toPrint.Append(new[] { '!', '?', '#' }[random.Next(3)]);

//v.
toPrint.Append(name[^1][^2..].ToUpper());

Console.WriteLine(toPrint);
#endregion

#region 5.feladat
toPrint.Clear();

char[] vowels = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };

Console.Write("\nAdjon meg egy szöveget: ");

foreach (char ch in Console.ReadLine() ?? "")
{
    toPrint.Append(vowels.Contains(char.ToLower(ch)) ? $"{ch}v{ch}" : ch);
}

Console.WriteLine(toPrint);
#endregion

#region 6.feladat
Console.Write("\nAdjon meg egy e-mail címet: ");
string emailAddress = (Console.ReadLine() ?? "").Trim();
var validator = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

Console.WriteLine($"A megadott e-mail cím " +
    $"{(validator.IsMatch(emailAddress) ? "helyes" : "helytelen")}.");
#endregion

#region 7.feladat
//a.
Console.Write("\nAdjon meg egy jelszót: ");
string password = Console.ReadLine() ?? "";

Console.Write("Adja meg a jelszót újra: ");
string retypedPassword = Console.ReadLine() ?? "";

//b.
if(password != retypedPassword) Console.WriteLine("A két jelszó nem egyezik!");

//c.
if(password.Length < 8) Console.WriteLine("A jelszó hossza nem éri el a 8 karaktert!");

//d.
if(!password.Any(char.IsUpper)) Console.WriteLine("A jelszó nem tartalmaz nagybetűt!");

//e.
if(!password.Any(char.IsLower)) Console.WriteLine("A jelszó nem tartalmaz kisbetűt!");

//f.
if(!password.Any(new[] { '!', '?', '.', '@', '#', '$' }.Contains))
    Console.WriteLine("A jelszó nem tartalmaz speciális karaktert!");

//g.
if(!password.Any(char.IsDigit)) Console.WriteLine("A jelszó nem tartalmaz számot!");
#endregion

#region 8.feladat
//a.
Console.Write("\nAdja meg a titkosítandó szót (max 15 karakter): ");
string str3 = Console.ReadLine() ?? "";

var odd = new StringBuilder(str3.Length / 2);
var even = new StringBuilder(str3.Length / 2);

for (int i = 0; i < str3.Length; i++)
{
    if (i % 2 == 0) even.Append(str3[i]);
    else odd.Append(str3[i]);
}

Console.WriteLine(odd + string.Concat(even.ToString().Reverse()));

//b.
Console.Write("\nAdja meg a feloldandó szót (max 15 karakter): ");
string str4 = Console.ReadLine() ?? "";

string firstHalf = str4[..(str4.Length / 2)];
string secondHalf = string.Concat(str4[(str4.Length / 2)..].Reverse());

toPrint.Clear();

for (int i = 0; i < firstHalf.Length + secondHalf.Length; i++)
{ 
    toPrint.Append((i % 2 == 0 ? secondHalf : firstHalf)[i / 2]);
}

Console.WriteLine(toPrint);
#endregion