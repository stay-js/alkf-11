using System.Text.RegularExpressions;

Random random = new Random();

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
Console.Write("Adjon meg egy szót, amely legalább 3 betűből áll: ");
string word = Console.ReadLine() ?? "";
Console.WriteLine(word[0] 
                  + string.Concat(word[1..^1].ToList().OrderBy(_ => random.Next()))
                  + word[^1]);
#endregion

#region 2.feladat
Console.Write("Adjon meg egy szót: ");
string word1 = Console.ReadLine() ?? "";

Console.Write("Adjon meg egy szót: ");
string word2 = Console.ReadLine() ?? "";

//a.
Console.WriteLine(word1 + word2);

//b.
if (word1.Length == word2.Length)
    Console.WriteLine("A két szó hossza megegyezik.");
else
    Console.WriteLine($"{
        (word1.Length > word2.Length ? "Az első" : "A második")
    } szó a hosszabb.");

//c.
Console.WriteLine($"{word1};{word2}");

//d.
Console.WriteLine(word1 + string.Concat(word2.Reverse()));

//e.
string newWord = "";
for (int i = 0; i < (word1.Length > word2.Length ? word1.Length : word2.Length); i++)
{
    if (i % 2 == 0)
        newWord += i >= word2.Length ? '*' : word2[i];
    else
        newWord += i >= word1.Length ? '*' : word1[i];

}
Console.WriteLine(newWord);
#endregion

#region 3. feladat
Console.Write("Adjon meg egy szöveget: ");
string str2 = Console.ReadLine() ?? "";

//a.
Console.WriteLine(string.Concat(str2.Reverse()));

//b.
Console.WriteLine(str2.Replace("  ", " "));

//c.
Console.WriteLine(str2.Trim());

//d.
string lowerTrimmedStr2 = str2.Trim().ToLower();
Console.WriteLine($"A szó{
    (lowerTrimmedStr2 != string.Concat(lowerTrimmedStr2.Reverse()) ? " nem " : " ")
}palindrom.");

//e.
string upperToLowerLowerToUpperStr2 = "";
foreach (char c in str2)
{ 
    upperToLowerLowerToUpperStr2 += char.IsLower(c)? char.ToUpper(c) : char.ToLower(c);
}
Console.WriteLine(upperToLowerLowerToUpperStr2);
#endregion

#region 4.feladat
Console.Write("Adja meg a teljes nevét: ");
string fullName = Console.ReadLine() ?? "";

string[] fullNameAsArray = fullName.Split(" ");

string firstName = fullNameAsArray[0];
string lastName = fullNameAsArray[1];
string secondLastName = fullNameAsArray.Length >= 3 ? string.Join(" ", fullNameAsArray[2..]) : "";

//a.
Console.WriteLine(fullName.ToLower().Replace(" ", "."));

//b.
string password = "";

//i.
password += firstName[..2].ToLower();

//ii.
for (int i = 0; i < 3; i++) 
{
     password += random.Next(0, 10);
}

//iii.
for (int i = 0; i < lastName.Length; i++) 
{
     if (i % 2 != 0) password += lastName[i];
}

//iv.
password += new char[] {'!', '?', '#'}[random.Next(0, 3)];

//v.
password += (secondLastName == "" ? lastName : secondLastName)[^2..].ToUpper();

Console.WriteLine(password);
#endregion

#region 5.feladat
Console.Write("Adj meg egy mondatot: ");
string sentence = Console.ReadLine() ?? "";
char[] vowels = new char[] { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű'  };

string newSentence = "";
foreach (char ch in sentence)
{
    newSentence += vowels.Contains(ch) ? $"{ch}v{ch}" : ch;
}
Console.WriteLine(newSentence);
#endregion

#region 6.feladat
Console.Write("Adjon meg egy e-mail címet: ");
string emailAddress = (Console.ReadLine() ?? "").Trim();

Regex validator = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
Console.WriteLine($"A megadott e-mail cím {
    (validator.IsMatch(emailAddress) ? "helyes" : "helytelen")
}.");
#endregion

#region 7.feladat
//a.
Console.Write("Adjon meg egy jelszót: ");
string password1 = Console.ReadLine() ?? "";

Console.Write("Adja meg a jelszót újra: ");
string password2 = Console.ReadLine() ?? "";

//b.
if(password1 != password2) Console.WriteLine("A két jelszó nem egyezik!");

//c.
if(password1.Length < 8) Console.WriteLine("A jelszó hossza nem éri el a 8 karaktert!");

//d.
bool upperCase = false;
int j = 0;
while (!upperCase && j < password1.Length)
{
    if (char.IsUpper(password1[j])) upperCase = true;
    j++;
}
if(!upperCase) Console.WriteLine("A jelszó nem tartalmaz nagybetűt!");

//e.
bool lowerCase = false;
j = 0;
while (!lowerCase && j < password1.Length)
{
    if (char.IsLower(password1[j])) lowerCase = true;
    j++;
}
if(!lowerCase) Console.WriteLine("A jelszó nem tartalmaz kisbetűt!");

//f.
char[] specialChars = new[] { '!', '?', '.', '@', '#', '$' };
bool specialChar = false;

j = 0;
while (!specialChar && j < specialChars.Length)
{
    if (password1.Contains(specialChars[j])) specialChar = true;
    j++;
}
if(!specialChar) Console.WriteLine("A jelszó nem tartalmaz speciális karaktert!");

//g.
bool number = false;
j = 0;
while (!number && j < password1.Length)
{
    if (char.IsNumber(password1[j])) number = true;
    j++;
}
if(!number) Console.WriteLine("A jelszó nem tartalmaz számot!");
#endregion

#region 8.feladat
//a.
Console.Write("Adja meg a titkosítandó szöveget (max 15 karakter): ");
string str3 = Console.ReadLine() ?? "";

string odd = "";
string even = "";

for (int i = 0; i < str3.Length; i++)
{
    if (i % 2 == 0) even += str3[i];
    else odd += str3[i];
}

Console.WriteLine(odd + string.Concat(even.Reverse()));

//b.
Console.Write("Adja meg a feloldandó szöveget (max 15 karakter): ");
string str4 = Console.ReadLine() ?? "";
string firstHalf = str4[..(str4.Length / 2)];
string secondHalf = string.Concat(str4[(str4.Length / 2)..].Reverse());

str4 = "";

for (int i = 0; i < firstHalf.Length + secondHalf.Length; i++)
{ 
    str4 += (i % 2 == 0 ? secondHalf : firstHalf)[i / 2];
}

Console.WriteLine(str4);
#endregion