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



        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }

    // --- Question 2 ---

    static void StudentGrade()
    {
        Console.Clear();
        Console.WriteLine("--- Student Grade Calculator ---");

        // ENTER YOUR CODE HERE

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
    }
}