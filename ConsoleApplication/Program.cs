using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your full name: ");
            var fullName = Console.ReadLine();
            Console.Write("Please enter your location: ");
            var location = Console.ReadLine();

            //Output user infos
            Console.WriteLine($"Your name is: { fullName }");
            Console.WriteLine($"You are from: { location }");

            // days until Christmas
            var today = DateTime.Now;
            var christmas = new DateTime(today.Year, 12, 25);


            //calculate number of days until christmas and output the value
            //use class time span
            TimeSpan duration = christmas - today;
            var totalDays = Math.Floor(duration.TotalDays);

            Console.WriteLine($"It is { totalDays } days until Christmas");

            // Book Code
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the width: ");
            widthString = Console.ReadLine();

            width = double.Parse(widthString);

            Console.Write("Please enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press <Enter> to exit");
            Console.ReadLine();
        }
    }
}
