using System;

class GradeCalculator
{
    static void Main()
    {
        int grade = -1;
        
        // Loop until a valid grade between 0 and 100 is entered
        while (grade < 0 || grade > 100)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();
            
            // Validate the input and parse it to an integer
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
            }
        }

        // Determine and display the letter grade
        if (grade >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }
}
