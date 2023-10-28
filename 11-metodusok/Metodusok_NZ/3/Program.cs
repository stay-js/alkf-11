int amount;

do Console.Write("Adja meg a felváltandó összeget (természetes szám): ");
while (!int.TryParse(Console.ReadLine(), out amount) || amount < 0);

Penzvaltas(amount);


static void Penzvaltas(int osszeg)
{
    osszeg = Convert.ToInt32(Math.Round(osszeg / 5.0) * 5);
    int[] coins = { 200, 100, 50, 20, 10, 5 };
    var coinsUsed = new List<int>();

    foreach (int coin in coins)
    {
        while (osszeg >= coin)
        {
            coinsUsed.Add(coin);
            osszeg -= coin;
        }
    }

    Console.WriteLine($"Kerekített érték: {coinsUsed.Sum()}, felhasznált érmék: {string.Join(", ", coinsUsed)}");
}