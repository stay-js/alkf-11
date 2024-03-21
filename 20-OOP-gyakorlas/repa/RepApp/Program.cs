using RepApp;

var repa = new Repa();
Console.WriteLine(repa);

Console.WriteLine(repa.Tick(23, 0.5));
Console.WriteLine(repa);

var repa2 = new Repa("teszt");
Console.WriteLine(repa2);

Console.WriteLine(repa2.Tick(43, 0.75));
Console.WriteLine(repa2);

var repa3 = new Repa();
Console.WriteLine(repa3);

repa3.Minoseg = 8;
Console.WriteLine(repa3);

repa3.Minoseg = -1;
Console.WriteLine(repa3);

repa3.Minoseg = 1.0 / 3.0;
Console.WriteLine(repa3);
