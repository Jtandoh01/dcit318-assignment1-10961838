class GradeCalculator
{
    static void Main()
    {
        int grade = -1;
        while (grade < 0 || grade > 100)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
            }
        }

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