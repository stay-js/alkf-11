//Nagy Zétény 11.a (11_SZFT1)

//1.feladat
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

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

//2. feladat
Console.Write("Adjon meg egy számot: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Adjon meg egy számot: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Két szám összege: {x + y}");
Console.WriteLine($"Két szám különbsége: {x - y}");
Console.WriteLine($"Két szám szorzata: {x * y}");
Console.WriteLine($"A második szám {x / y}x van meg az első számban.");
Console.WriteLine($"Két szám osztási maradéka: {x % y}");
Console.WriteLine($"Valós osztás eredménye: {Convert.ToDecimal(x) / y}");

//3. feladat
Console.Write("Adjon meg egy születési évet: ");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A megadott évben született diák {DateTime.Today.Year - year} éves.");

//4. feladat
Console.Write("Adja meg, hogy hány pontot ért el: ");
int score = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Az ön által elért eredmény: {(score / 120.0 * 100):N2}%");

//5. feladat
Console.WriteLine("Adja meg egy háromszög 3 oldalát!");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A háromszög kerülete: {a + b + c}");

//6. feladat
Console.Write("Adja meg a testsúlyát: ");
float weight = Convert.ToSingle(Console.ReadLine());

Console.Write("Adja meg a magasságát: ");
float height = Convert.ToSingle(Console.ReadLine());

Console.WriteLine($"Az ön testtömegindexe: {(weight / Math.Pow(height / 100, 2)):N2}");

//7. feladat
Console.Write("Adja meg, hogy mennyi eurót szeretne vásárolni: ");
float eurToBuy = Convert.ToSingle(Console.ReadLine());

Console.Write("Adja meg az euró aktuális árfolyamát: ");
float eurToHuf = Convert.ToSingle(Console.ReadLine());

Console.WriteLine($"{eurToBuy} EUR-ért {eurToBuy * eurToHuf} Ft-ot kell fizetni.");

//8. feladat
Console.Write("Adja meg az első tört számlálóját: ");
int aSz = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az első tört nevezőjét: ");
int aN = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az második tört számlálóját: ");
int bSz = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az második tört nevezőjét: ");
int bN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A két tört összege: {(aSz * bN) + (bSz * aN)}/{(aN * bSz) + (bN * aSz)}");
Console.WriteLine($"A két tört különbsége: {(aSz * bN) - (bSz * aN)}/{(aN * bSz) - (bN * aSz)}");
Console.WriteLine($"A két tört szorzata: {aSz * bSz}/{aN * bN}");
Console.WriteLine($"A két tört hányadosa: {aSz / bSz}/{aN / bN}");

//9. feladat
Console.Write("Adja meg, hogy hány kg almát vásárolt: ");
float appleKg = Convert.ToSingle(Console.ReadLine());
float apple = appleKg * 240;

Console.Write("Adja meg, hogy hány kg szilvát vásárolt: ");
float plumKg = Convert.ToSingle(Console.ReadLine());
float plum = plumKg * 310;

Console.Write("Adja meg, hogy hány kg szőlőt vásárolt: ");
float grapeKg = Convert.ToSingle(Console.ReadLine());
float grape = grapeKg * 650;

Console.WriteLine($"- {appleKg} kg alma - {apple} Ft");
Console.WriteLine($"- {plumKg} kg szilva - {plum} Ft");
Console.WriteLine($"- {grapeKg} kg szőlő - {grape} Ft");
Console.WriteLine($"Összesen: {apple + plum + grape} Ft");

//10. feladat
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

//11. feladat
Console.Write("Adja meg a szoba falfelületét: ");
int allArea = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az ablak felületét: ");
int windowArea = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az ajtó felületét: ");
int doorArea = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{((allArea - windowArea - doorArea) * 1.1 / 1000):N2} m2 tapétára van szükség.");

//12. feladat
Console.Write("Adja meg az egyik oldalt (m): ");
int aInM = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg az másik oldalt (m): ");
int bInM = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg a kapu méretét (cm): ");
int gateInCm = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{((2 * (aInM + bInM) * 100) - gateInCm) / 20} db lécre van szükség.");