#region 1.feladat
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Hey, hey");

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Word of advice");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Always remember where you came from, nah mean?");

Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("'Cause, they just gon' remember how you came up");

Console.ResetColor();
#endregion

#region 2. feladat
Console.Write("\nAdjon meg egy számot: ");
int x = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adjon meg egy számot: ");
int y = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"\nKét szám összege: {x + y}" +
    $"\nKét szám különbsége: {Math.Abs(x - y)}" +
    $"\nKét szám szorzata: {x * y}" +
    $"\nA második szám {x / y}x van meg az első számban." +
    $"\nKét szám osztási maradéka: {x % y}" +
    $"\nValós osztás eredménye: {Convert.ToDouble(x) / y}");
#endregion

#region 3. feladat
Console.Write("\nAdja meg a diák születési évet: ");
int year = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"A megadott évben született diák {DateTime.Today.Year - year} éves.");
#endregion

#region 4. feladat
Console.Write("\nAdja meg, hogy hány pontot ért el: ");
double score = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Az ön által elért eredmény: {score / 120 * 100:N2}%");
#endregion

#region 5. feladat
Console.Write("\nAdja a háromszög \"a\" oldalát: ");
int a = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja a háromszög \"b\" oldalát: ");
int b = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja a háromszög \"c\" oldalát: ");
int c = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"A háromszög kerülete: {a + b + c}");
#endregion

#region 6. feladat
Console.Write("\nAdja meg a testsúlyát (kg): ");
double weight = double.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg a magasságát (cm): ");
double height = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"Az ön testtömegindexe: {weight / Math.Pow(height / 100, 2):N2}");
#endregion

#region 7. feladat
Console.Write("\nAdja meg, hogy mennyi eurót szeretne vásárolni: ");
double eurToBuy = double.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az euró aktuális árfolyamát: ");
double eurToHuf = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"{eurToBuy} EUR-ért {eurToBuy * eurToHuf:C0}-ot kell fizetni.");
#endregion

#region 8. feladat
Console.Write("\nAdja meg az első tört számlálóját: ");
int xN = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az első tört nevezőjét: ");
int xD = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az második tört számlálóját: ");
int yN = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az második tört nevezőjét: ");
int yD = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"A két tört összege: {(xN * yD) + (yN * xD)}/{xD * yD} " +
    $"A két tört különbsége: {(xN * yD) - (yN * xD)}/{xD * yD} " +
    $"A két tört szorzata: {xN * yN}/{xD * yD} " +
    $"A két tört hányadosa: {xN * yD}/{xD * yN}");
#endregion

#region 9. feladat
Console.Write("\nAdja meg, hogy hány kg almát vásárolt: ");
double appleKg = double.Parse(Console.ReadLine() ?? "");
double apple = appleKg * 240;

Console.Write("Adja meg, hogy hány kg szilvát vásárolt: ");
double plumKg = double.Parse(Console.ReadLine() ?? "");
double plum = plumKg * 310;

Console.Write("Adja meg, hogy hány kg szőlőt vásárolt: ");
double grapeKg = double.Parse(Console.ReadLine() ?? "");
double grape = grapeKg * 650;

Console.WriteLine($"\nÖsszesen: {apple + plum + grape:C0}" +
    $"\n\t- {appleKg} kg alma - {apple:C0}" +
    $"\n\t- {plumKg} kg szilva - {plum:C0}" +
    $"\n\t- {grapeKg} kg szőlő - {grape:C0}");
#endregion

#region 10. feladat
Console.BackgroundColor = ConsoleColor.Red;
Console.Clear();
Console.Write("Hány ilyen színű lufit kér? ");
int red = int.Parse(Console.ReadLine() ?? "");

Console.BackgroundColor = ConsoleColor.Green;
Console.Clear();
Console.Write("Hány ilyen színű lufit kér? ");
int green = int.Parse(Console.ReadLine() ?? "");

Console.BackgroundColor = ConsoleColor.Blue;
Console.Clear();
Console.Write("Hány ilyen színű lufit kér? ");
int blue = int.Parse(Console.ReadLine() ?? "");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();
Console.WriteLine($"Fizetendő összeg: {(red * 125) + (green * 150) + (blue * 135):C0}");
Console.ResetColor();
#endregion

#region 11. feladat
Console.Write("\nAdja meg a szoba falfelületét: ");
int roomArea = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az ablak felületét: ");
int windowArea = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg az ajtó felületét: ");
int doorArea = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"{(roomArea - windowArea - doorArea) * 1.1 / 1000:N2} " +
    $"m2 tapétára van szükség.");
#endregion

#region 12. feladat
Console.Write("\nAdja meg az egyik oldalt (m): ");
int aInM = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg a másik oldalt (m): ");
int bInM = int.Parse(Console.ReadLine() ?? "");

Console.Write("Adja meg a kapu méretét (cm): ");
int gateInCm = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"{((2 * (aInM + bInM) * 100) - gateInCm) / 20} db lécre van szükség.");
#endregion