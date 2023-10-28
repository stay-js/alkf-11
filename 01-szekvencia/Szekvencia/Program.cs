// Nagy Zétény 11.a (11_SZFT1)

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
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Adjon meg egy számot: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nKét szám összege: {x + y}");
Console.WriteLine($"Két szám különbsége: {x - y}");
Console.WriteLine($"Két szám szorzata: {x * y}");
Console.WriteLine($"A második szám {x / y}x van meg az első számban.");
Console.WriteLine($"Két szám osztási maradéka: {x % y}");
Console.WriteLine($"Valós osztás eredménye: {Convert.ToDecimal(x) / y}");
#endregion

#region 3. feladat
Console.Write("\nAdjon meg egy születési évet: ");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A megadott évben született diák {DateTime.Today.Year - year} éves.");
#endregion

#region 4. feladat
Console.Write("\nAdja meg, hogy hány pontot ért el: ");
double score = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Az ön által elért eredmény: {(score / 120 * 100):N2}%");
#endregion

#region 5. feladat
Console.Write("\nAdja a háromszög \"a\" oldalát: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja a háromszög \"b\" oldalát: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja a háromszög \"c\" oldalát: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A háromszög kerülete: {a + b + c}");
#endregion

#region 6. feladat
Console.Write("\nAdja meg a testsúlyát: ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Adja meg a magasságát: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Az ön testtömegindexe: {(weight / Math.Pow(height / 100, 2)):N2}");
#endregion

#region 7. feladat
Console.Write("\nAdja meg, hogy mennyi eurót szeretne vásárolni: ");
double eurToBuy = Convert.ToDouble(Console.ReadLine());

Console.Write("Adja meg az euró aktuális árfolyamát: ");
float eurToHuf = Convert.ToSingle(Console.ReadLine());

Console.WriteLine($"{eurToBuy} EUR-ért {eurToBuy * eurToHuf} Ft-ot kell fizetni.");
#endregion

#region 8. feladat
Console.Write("\nAdja meg az első tört számlálóját: ");
double aSz = Convert.ToDouble(Console.ReadLine());

Console.Write("Adja meg az első tört nevezőjét: ");
double aN = Convert.ToDouble(Console.ReadLine());

Console.Write("Adja meg az második tört számlálóját: ");
double bSz = Convert.ToDouble(Console.ReadLine());

Console.Write("Adja meg az második tört nevezőjét: ");
int bN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A két tört összege: {(aSz * bN) + (bSz * aN)}/{(aN * bSz) + (bN * aSz)}");
Console.WriteLine($"A két tört különbsége: {(aSz * bN) - (bSz * aN)}/{(aN * bSz) - (bN * aSz)}");
Console.WriteLine($"A két tört szorzata: {aSz * bSz}/{aN * bN}");
Console.WriteLine($"A két tört hányadosa: {aSz / bSz}/{aN / bN}");
#endregion

#region 9. feladat
Console.Write("\nAdja meg, hogy hány kg almát vásárolt: ");
double appleKg = Convert.ToDouble(Console.ReadLine());
double apple = appleKg * 240;

Console.Write("Adja meg, hogy hány kg szilvát vásárolt: ");
double plumKg = Convert.ToDouble(Console.ReadLine());
double plum = plumKg * 310;

Console.Write("Adja meg, hogy hány kg szőlőt vásárolt: ");
double grapeKg = Convert.ToDouble(Console.ReadLine());
double grape = grapeKg * 650;

Console.WriteLine($"- {appleKg} kg alma - {apple} Ft");
Console.WriteLine($"- {plumKg} kg szilva - {plum} Ft");
Console.WriteLine($"- {grapeKg} kg szőlő - {grape} Ft");
Console.WriteLine($"Összesen: {apple + plum + grape} Ft");
#endregion

#region 10. feladat
Console.BackgroundColor = ConsoleColor.Red;
Console.Clear();
Console.Write("Hány ilyen színű lufit kér? ");
int red = Convert.ToInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Green;
Console.Clear();
Console.Write("Hány ilyen színű lufit kér? ");
int green = Convert.ToInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Blue;
Console.Clear();
Console.Write("Hány ilyen színű lufit kér? ");
int blue = Convert.ToInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();
Console.WriteLine($"Fizetendő összeg: {(red * 125) + (green * 150) + (blue * 135)} Ft");
Console.ResetColor();
#endregion

#region 11. feladat
Console.Write("\nAdja meg a szoba falfelületét: ");
int allArea = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az ablak felületét: ");
int windowArea = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az ajtó felületét: ");
int doorArea = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{((allArea - windowArea - doorArea) * 1.1 / 1000):N2} m2 tapétára van szükség.");
#endregion

#region 12. feladat
Console.Write("\nAdja meg az egyik oldalt (m): ");
int aInM = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az másik oldalt (m): ");
int bInM = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg a kapu méretét (cm): ");
int gateInCm = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{((2 * (aInM + bInM) * 100) - gateInCm) / 20} db lécre van szükség.");
#endregion