int a, b;

do Console.Write("Adjon meg egy számot: ");
while (!int.TryParse(Console.ReadLine(), out a));

do Console.Write("Adjon meg egy számot: ");
while (!int.TryParse(Console.ReadLine(), out b));

Console.WriteLine($"{a} és {b} legnagyobb közös osztója: {greatestCommonDivisor(a, b)}");


static int greatestCommonDivisor(int a, int b)
{
    while (b != 0)
    {
        (a, b) = (b, a % b);
    }

    return a;
}