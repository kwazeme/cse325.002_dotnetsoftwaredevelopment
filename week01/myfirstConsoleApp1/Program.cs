// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current date and time is: " + DateTime.Now);
// Statmeent that provides the number of days until next christmas
DateTime today = DateTime.Now;
DateTime nextChristmas = new DateTime(today.Year, 12, 25);
if (today > nextChristmas)
{
    nextChristmas = nextChristmas.AddYears(1);
}
Console.WriteLine("There are " + (nextChristmas - today).Days + " days until the next Christmas.");
