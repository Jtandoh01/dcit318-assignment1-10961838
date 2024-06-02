using System;

class TicketPriceCalculator
{
    static void Main()
    {
        int age = -1;
        
        // Loop until a valid age (non-negative integer) is entered
        while (age < 0)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            
            // Validate the input and parse it to an integer
            if (int.TryParse(input, out age) && age >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        // Determine the ticket price based on the age
        int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;
        Console.WriteLine("Ticket Price: GHC" + ticketPrice);
    }
}
