using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        
        Console.Write("Enter number of numbers you want to generate: ");
        int n = Convert.ToInt32(Console.ReadLine());
    
        int sum = 0;
        // Generate, print and sum random numbers
        for (int i = 0; i < n; i++)
        {
            int randomNumber = rnd.Next(10000, 100000);// Generate a 5 digit random number
            Console.Write("  ");
            PrintNumberWithSpaces(randomNumber);
            sum += randomNumber;
        }
        
        // Print the sum with spaces between its digits
        Console.WriteLine("\nPress enter to know the addtion result:");
        Console.ReadKey(true);
        PrintNumberWithSpaces(sum);
    }
    
    // Method to print a number with spaces between its digits
    static void PrintNumberWithSpaces(int number)
    {
        string numberString = number.ToString();
        Console.WriteLine(string.Join(" ", numberString.ToCharArray()));
    }
}