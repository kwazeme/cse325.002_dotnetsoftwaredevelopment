// See https://aka.ms/new-console-template for more information
// add Humanizer dependency
using Humanizer;

Console.WriteLine("Quantities:");
HumanizeQuantities();

Console.WriteLine("\nDate/Time Manipulation:");
HumanizeDates();

// implementation that uses Humanizer

static void HumanizeQuantities()
{
    Console.WriteLine("case".ToQuantity(0)); // "no cases"
    Console.WriteLine("case".ToQuantity(1)); // "1 case"
    Console.WriteLine("case".ToQuantity(5)); // "5 cases"
}

//Implementation uses Humaniizer to display Dates
static void HumanizeDates()
{
   Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize()); // "yesterday"
   Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
   Console.WriteLine(TimeSpan.FromDays(1).Humanize());
   Console.WriteLine(TimeSpan.FromDays(16).Humanize());
   
}