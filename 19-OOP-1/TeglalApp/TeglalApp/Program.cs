using TeglalApp;

var teglA = new Teglalap();
Console.WriteLine(teglA);

teglA.A = -32;
Console.WriteLine(teglA);

var teglB = new Teglalap(3, 4);
Console.WriteLine(teglB);

teglB.A = 1202.5435;
teglB.B = -1202.5435;
Console.WriteLine(teglB);
