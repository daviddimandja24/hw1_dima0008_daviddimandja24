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
        double tickets = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"What is the price for each {item}");
        double price = Convert.ToDouble(Console.ReadLine());

        // calculate total
        double subtotal = tickets * price;
        double sales_tax = subtotal * .085;
        

            Console.WriteLine($"Your subtotal for your bill is {subtotal:C2}");
            Console.WriteLine($"Your sales tax for your bill is {sales_tax:C2}");
            Console.WriteLine($"Your total for your bill is {subtotal + sales_tax:C2}");

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

        double totalsum = (homeworks + participations + quizzes + midterm + final);
        double percentage = ((homeworks + participations + quizzes + midterm + final) / totalsum) * 100;

        Console.WriteLine($"{first_name} {last_name} ({student_id}), your final grade is {percentage:F2}%");
        
        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}