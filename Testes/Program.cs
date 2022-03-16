Console.WriteLine($"{DateTime.Compare(DateTime.Now, DateTime.Parse("12-03-2022"))}");
Console.WriteLine($"{DateTime.Now - DateTime.Parse("10-03-2022")}");

if (DateTime.Now - DateTime.Parse("15-02-2022") >= TimeSpan.Parse("30.00:00:00"))
{
    Console.WriteLine("A");
}
else
{
    Console.WriteLine($"B {DateTime.Now - DateTime.Parse("15-02-2022")}");
}
