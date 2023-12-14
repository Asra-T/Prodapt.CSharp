namespace Prodapt.CSharp.Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now;
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Today : {today}");
            Console.WriteLine($"Dateonly : {today.ToShortDateString()}");
            Console.WriteLine($"Dateonly : {today.ToShortDateString()}");
        }
    }
}
