using Ijaszat;

var tesztIjasz = new Ijasz(-1);
Console.WriteLine(tesztIjasz);

tesztIjasz = new Ijasz(1200);
Console.WriteLine(tesztIjasz);

tesztIjasz.AlloKepesseg = -12;
Console.WriteLine(tesztIjasz);

tesztIjasz.AlloKepesseg = 1013;
Console.WriteLine(tesztIjasz + "\n");

var log = new StreamWriter("log.txt");

var kezdoIjasz = new Ijasz();
Console.WriteLine(kezdoIjasz);
log.WriteLine(kezdoIjasz);

var ugyesIjasz = new Ijasz(Random.Shared.Next(3, 6));
Console.WriteLine(ugyesIjasz);
log.WriteLine(ugyesIjasz);

while (true)
{
    Console.Write("\nVálassza ki az íjászt (k/u): ");
    string selection = Console.ReadLine() ?? "";

    if (selection == "k") HandleArcher(kezdoIjasz);
    else if (selection == "u") HandleArcher(ugyesIjasz);
    else break;
}

log.Close();


void HandleArcher(Ijasz archer)
{
    Console.Write("Válassza ki, hogy mit csináljon az íjász (l/p): ");
    string selection = Console.ReadLine() ?? "";
    string toLog = "";

    if (selection == "l")
    {
        toLog = archer.Lo()
            ? "Az íjász ellőtte a nyilat."
            : "Az íjász túl fáradt, pihennie kell.";
    }
    else if (selection == "p")
    {
        archer.Pihen();
        toLog = "Az íjász pihent.";
    }

    Console.WriteLine(toLog);
    log.WriteLine(toLog);

    Console.WriteLine(archer);
    log.WriteLine(archer);
}