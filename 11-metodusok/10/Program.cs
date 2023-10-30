using System.Text.RegularExpressions;

Console.Write("\nAdjon meg egy e-mail címet: ");
string emailAddress = (Console.ReadLine() ?? "").Trim();

Console.WriteLine($"A megadott e-mail cím " +
    $"{(isValidEmail(emailAddress) ? "helyes" : "helytelen")}.");


static bool isValidEmail(string email)
{
    var validator = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
    return validator.IsMatch(email);
}
