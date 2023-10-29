Console.Write("Kérem a regisztrációs kódot: ");
string code = (Console.ReadLine() ?? "").Trim().Replace("-", "");

if (code.Length != 12)
{
    Console.WriteLine("A kód nem megfelelő hosszúságú.");
}
else if (!code.Any(ch => ch is 't' or 'i' or 'g'))
{
    Console.WriteLine("A kód a 't', 'i', 'g', karakterek közül valamelyiket nem tartalmazza.");
}
else if (char.IsNumber(code[0]) || char.IsNumber(code[^1]))
{
    Console.WriteLine("A kód első vagy utolsó karaktere számjegy.");
}
else if (!code.Any(char.IsDigit))
{
    Console.WriteLine("A kód nem tartalmaz számjegyet");
}
else
{
    Console.WriteLine("A beolvasott kód a megadott szabályoknak megfelel.");
}
