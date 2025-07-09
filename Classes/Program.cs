namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.make = "Buick";
            carOne.model = "Encore";
            carOne.year = 2019;
            
           Console.WriteLine($"This is a {carOne.make} {carOne.model}, made in the year {carOne.year}.");
        }
    }
}
