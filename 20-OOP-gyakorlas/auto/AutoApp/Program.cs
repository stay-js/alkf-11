using AutoApp;

var totoka1 = new Auto();
Console.WriteLine(totoka1.Log());
Console.WriteLine(totoka1.Tipus);
Console.WriteLine(totoka1.SebessegMeres());

var totoka2 = new Auto("Suzuki Swift", "Lázár Boldizsár", 210);
Console.WriteLine(totoka2.Log());

Console.WriteLine(totoka2.SebessegMeres());
Console.WriteLine(totoka2.SebessegMeres());
Console.WriteLine(totoka2.SebessegMeres());
Console.WriteLine(totoka2.SebessegMeres());
Console.WriteLine(totoka2.SebessegMeres());

Console.WriteLine(totoka2.Log());

var totoka3 = new Auto("Suzuki Wagon R+", "Révész Barnabás", 90);
Console.WriteLine(totoka3.MaxSebesseg);

Console.WriteLine(totoka3.SebessegMeres());
Console.WriteLine(totoka3.SebessegMeres());
Console.WriteLine(totoka3.SebessegMeres());
Console.WriteLine(totoka3.SebessegMeres());
Console.WriteLine(totoka3.SebessegMeres());

Console.WriteLine(totoka3.Log());

Console.WriteLine(totoka2.Osszehasonlitas(totoka3));
