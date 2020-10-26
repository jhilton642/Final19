using System;

namespace Final19
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("how many miles? (0 to exit) : ");
                double miles = Convert.ToDouble(Console.ReadLine());
                if(miles == 0)
                {
                    break;
                }
                Console.WriteLine("What would you like to convert the miles too? (km, meter, yard, feet, inch) : ");
                string convertTo = Console.ReadLine();
                Program.milesConversion(miles, convertTo);
            }
        }
        public static void milesConversion(double miles, string convertTo)
        {
            double converted;
            switch (convertTo)
            {
                case "km":
                    converted = miles * 1.60934;
                    Console.WriteLine(miles + " miles is " + converted +" km");
                    break;
                case "meter":
                    converted = miles * 1609.34;
                    Console.WriteLine(miles + " miles is " + converted + " meters");
                    break;
                case "yard":
                    converted = miles * 1760;
                    Console.WriteLine(miles + " miles is " + converted + " yards");
                    break;
                case "feet":
                    converted = miles * 5280;
                    Console.WriteLine(miles + " miles is " + converted + " feet");
                    break;
                case "inch":
                    converted = miles * 63360;
                    Console.WriteLine(miles + " miles is " + converted + " inches");
                    break;
            }
            
        }
    }
}
