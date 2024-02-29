namespace _20_Leap_years_looping_app
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Hello! Please enter your name:");
            string name = Console.ReadLine();

           
            Console.WriteLine("Hello " + name + " welcome to the leap year looping app!");

           
            Console.WriteLine("Please enter the starting year to calculate the next 20 leap years:");
            int startingYear;
            while (!int.TryParse(Console.ReadLine(), out startingYear))
            {
                Console.WriteLine("Invalid input. Please enter a valid year:");
            }

            
            int leapYearsFound = 0;

            Console.WriteLine($"Next 20 leap years from {startingYear}:");

            
            while (leapYearsFound < 20)
            {
                
                if (DateTime.IsLeapYear(startingYear))
                {
                    Console.WriteLine(startingYear);
                    leapYearsFound++;
                }
                
                startingYear++;
            }

            Console.ReadLine();
        }
    }
}
