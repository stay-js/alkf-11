using TermekKeszlet;

var termek1 = new Termek("Suzuki Swift 1998 - 1.3L Benzin, Manuális", 199999);
Console.WriteLine(termek1.Informacio());

termek1.Kedvezmeny = 5.0;
Console.WriteLine(termek1.Informacio());

termek1.Kedvezmeny = 0.55;
termek1.RaktarKeszlet = 8;
Console.WriteLine(termek1.Informacio());

var termek2 = new Termek("Suzuki Swift 1998 - 1.0L Benzin, Automata", 219999, 21);
Console.WriteLine(termek2.Informacio());

Console.WriteLine(termek2.Eladas(24));

termek2.Beszerzes(3);
Console.WriteLine(termek2.Informacio());

Console.WriteLine(termek2.Eladas(24));
Console.WriteLine(termek2.Informacio());
