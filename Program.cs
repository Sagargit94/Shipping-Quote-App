using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main()
        {
            // Display the welcome message as required
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            // Read user input, convert from string to decimal
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if weight is greater than 50
            if (weight > 50)
            {
                // If too heavy, display error message and end program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program here
            }

            // Prompt user for package width
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package height
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt user for package length
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Calculate the sum of dimensions
            decimal dimensionTotal = width + height + length;

            // Check if total dimensions exceed 50
            if (dimensionTotal > 50)
            {
                // If too large, display error message and end program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program here
            }

            // Calculate the volume of the package (width × height × length)
            decimal volume = width * height * length;

            // Multiply volume by weight
            decimal total = volume * weight;

            // Divide the total by 100 to get the shipping quote
            decimal quote = total / 100;

            // Display the calculated shipping quote to user, formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

            // Thank the user
            Console.WriteLine("Thank you!");
        }
    }
}
