Console.Write("Adja meg az \"a\" értéket, vagy üssön üres entert: ");
double a = double.TryParse(Console.ReadLine(), out a) ? a : 0;

Console.Write("Adja meg a \"b\" értéket, vagy üssön üres entert: ");
double b = double.TryParse(Console.ReadLine(), out b) ? b : 0;

Console.Write("Adja meg a \"c\" értéket, vagy üssön üres entert: ");
double c = double.TryParse(Console.ReadLine(), out c) ? c : 0;

var result = QuadricEquation(a: a, b: b, c: c);

Console.WriteLine($"x1 = {(double.IsNaN(result.Item1) ? "nincs megoldás" : result.Item1)}, " +
    $"x2 = {(double.IsNaN(result.Item2) ? "nincs megoldás" : result.Item2)}");


static (double, double) QuadricEquation(double a = 0, double b = 0, double c = 0)
{
    double discriminant = Math.Pow(b, 2) - (4 * a * c);

    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

    return (x1, x2);
}