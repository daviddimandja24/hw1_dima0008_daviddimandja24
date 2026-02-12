using System;

class Program
{

    /* Go to Tools > Options.
     * In the search bar at the top left of the window, type IntelliCode.
     * Find C# user model predictions (or "Whole line completions") and set it to Disabled.
     * */

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            // Please write down your name first. 
            Console.WriteLine("My name is xxx xxx. My OU 4x4 is xxx, and my GitHub account name is @xxxxxx. \n");

            Console.WriteLine("=== CALCULATOR SYSTEM ===");
            Console.WriteLine("1) Calculate Sale Total");
            Console.WriteLine("2) Calculate Student Grade");
            Console.WriteLine("3) Exit");
            Console.Write("\nSelect an option: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                SaleTotal();
            }
            else if (input == "2")
            {
                StudentGrade();
            }
            else if (input == "3")
            {
                Console.WriteLine("Exiting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
            }
        }
    }

    // --- Question 1 ---

    static void SaleTotal()
    {
        Console.Clear();
        Console.WriteLine("--- Sale Total Calculator ---");

        // ENTER YOUR CODE HERE

        const double taxrate = 0.085;

        Console.WriteLine("What is the product name of the item you are purchasing?");
        string productname = Console.ReadLine();

        Console.WriteLine($"How many {productname}'s do you want to buy?");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"What is the price for each {productname}?");
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine($"Please enter the discount amount for the {productname}:");
        double discount = double.Parse(Console.ReadLine());

        double subtotal = (quantity * price) - discount;
        double salesTax = subtotal * taxrate;
        double total = subtotal + salesTax;

        Console.WriteLine($"\nYour subtotal for your bill is {subtotal:C2}.");
        Console.WriteLine($"Your sales tax for your bill is {salesTax:C2}.");
        Console.WriteLine($"Your total for your bill is {total:C2}.");


        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Question 2 ---

    static void StudentGrade()
    {
        Console.Clear();
        Console.WriteLine("--- Student Grade Calculator ---");

        // ENTER YOUR CODE HERE

        Console.WriteLine("What is your first name?");
        string firstname = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastname = Console.ReadLine();

        string fullName = firstname + " " + lastname;
        Console.WriteLine($"Good morning, {fullName}!");

        Console.WriteLine("What is your student ID?");
        string studentID = Console.ReadLine();

        Console.WriteLine("What is your grade for homeworks?");
        double hw_grade = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your grade for participations?");
        double parti_grade = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your grade for quizzes?");
        double quiz_grade = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your grade for the midterm?");
        double midterm_grade = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your grade for the final exam?");
        double finalexam_grade = Convert.ToDouble(Console.ReadLine());

        // enter percentage weights
        Console.WriteLine("What is the weight for homeworks? (between 0 - 1)");
        double hw_weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the weight for participations (between 0 - 1)?");
        double parti_weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the weight for quizzes? (between 0 - 1)");
        double quiz_weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the weight for the midterm? (between 0 - 1)");
        double midterm_weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the weight for the final exam? (between 0 - 1)");
        double finalexam_weight = Convert.ToDouble(Console.ReadLine());


        double finalgrade = hw_grade * hw_weight + parti_grade * parti_weight + quiz_grade * quiz_weight + midterm_grade * midterm_weight + finalexam_grade * finalexam_weight;

        Console.WriteLine($"{firstname} {lastname} ({studentID}): your grade is {finalgrade:F2}.");



        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}