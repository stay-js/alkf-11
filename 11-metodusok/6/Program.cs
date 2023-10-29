int number;

do Console.Write("Adjon meg egy számot: ");
while (!int.TryParse(Console.ReadLine(), out number));

Console.WriteLine($"A megadott szám {(isPrime(number) ? "prím" : "nem prím")}szám.");


static bool isPrime(int number)
{
    int dividers = 0;
    int i = 1;

    while (dividers < 3 && i < number)
    {
        if (number % i == 0) dividers++;
        i++;
    }

    return dividers < 3;
}