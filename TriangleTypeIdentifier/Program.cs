using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        // Get valid lengths for the three sides of the triangle
        double side1 = GetValidSide("Enter the length of side 1: ");
        double side2 = GetValidSide("Enter the length of side 2: ");
        double side3 = GetValidSide("Enter the length of side 3: ");

        // Determine and display the type of the triangle
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }

    // Function to get a valid side length (positive number)
    static double GetValidSide(string prompt)
    {
        double side = -1;
        
        // Loop until a valid side length (positive number) is entered
        while (side <= 0)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            
            // Validate the input and parse it to a double
            if (double.TryParse(input, out side) && side > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
        return side;
    }
}
