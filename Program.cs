using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message - first line as required
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            // Prompt user for package weight and validate input
            Console.WriteLine("Please enter the package weight:");
            string weightInput = Console.ReadLine();
            
            // Convert input to decimal for precise calculations with decimal values
            if (!decimal.TryParse(weightInput, out decimal weight))
            {
                Console.WriteLine("Invalid weight entered. Please enter a valid number.");
                Console.ReadLine();
                return;
            }
            
            // Check if package exceeds weight limit of 50
            if (weight > 50)
            {
                // Display error message and terminate program if too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            
            // Prompt user for package width and validate input
            Console.WriteLine("Please enter the package width:");
            string widthInput = Console.ReadLine();
            
            if (!decimal.TryParse(widthInput, out decimal width))
            {
                Console.WriteLine("Invalid width entered. Please enter a valid number.");
                Console.ReadLine();
                return;
            }
            
            // Prompt user for package height and validate input
            Console.WriteLine("Please enter the package height:");
            string heightInput = Console.ReadLine();
            
            if (!decimal.TryParse(heightInput, out decimal height))
            {
                Console.WriteLine("Invalid height entered. Please enter a valid number.");
                Console.ReadLine();
                return;
            }
            
            // Prompt user for package length and validate input
            Console.WriteLine("Please enter the package length:");
            string lengthInput = Console.ReadLine();
            
            if (!decimal.TryParse(lengthInput, out decimal length))
            {
                Console.WriteLine("Invalid length entered. Please enter a valid number.");
                Console.ReadLine();
                return;
            }
            
            // Calculate total dimensions by adding all three measurements
            decimal dimensionsTotal = width + height + length;
            
            // Check if total dimensions exceed the limit of 50
            if (dimensionsTotal > 50)
            {
                // Display error message and terminate program if too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            
            // Calculate package volume by multiplying all three dimensions
            decimal volume = width * height * length;
            
            // Calculate shipping quote: (volume × weight) ÷ 100
            decimal quote = (volume * weight) / 100;
            
            // Format the quote as currency with 2 decimal places
            string formattedQuote = quote.ToString("C2");
            
            // Display the final shipping quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: {formattedQuote}");
            Console.WriteLine("Thank you!");
            
            // Keep console window open until user presses Enter
            Console.ReadLine();
        }
    }
}