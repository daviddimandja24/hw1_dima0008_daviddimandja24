using System;
using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine("My name is David Dimandja. My OU 4x4 is dima0008, and my GitHub account name is @daviddimandja24. \n");

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
        Console.Write("What is product name of the item you are purchasing?");
        string item = Console.ReadLine();

        Console.WriteLine($"How many{item}'s do you want to buy?");
        int quantity = int.Parse(Console.ReadLine());

        Console.WriteLine($"What is the price for each {item}");
        double price = Convert.ToDouble(Console.ReadLine());

        // setup tax constant
        const double sales_tax_percent = .085;

        // calculate total
        double subtotal = quantity * price;
        double sales_tax = subtotal * sales_tax_percent;
        double total = subtotal + sales_tax;

        Console.WriteLine($"Your subtotal for your bill is {subtotal:C2}");
        Console.WriteLine($"Your sales tax for your bill is {sales_tax:C2}");
        Console.WriteLine($"Your total for your bill is {total:C2}");

        // also where you write your pseudocodes

        // Enter itemtype
        // string itemtype = "xxx";

        // Enter quantity
        // int qty


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
        string first_name = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();

        Console.WriteLine("What is your student id?");
        int student_id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is your overall percentage grade for homeworks?");
        double homeworks = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your overall percentage grade for participations?");
        double participations = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your overall percentage grade for quizzes?");
        double quizzes = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your overall percentage grade for the midterm?");
        double midterm = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is your overall percentage grade for the final?");
        double final = Convert.ToDouble(Console.ReadLine());

        const double homeworks_percentage = 0.20;
        const double particpations_percentage = 0.20;
        const double quizzes_percentage = 0.20;
        const double midterm_percentage = 0.20;
        const double final_percentage = 0.20;

        double final_grade = ((homeworks * homeworks_percentage) + (participations * particpations_percentage) + (quizzes * quizzes_percentage) + (midterm * midterm_percentage) + (final * final_percentage));

        Console.WriteLine($"{first_name} {last_name} ({student_id}), your final grade is {final_grade:F2}%");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}