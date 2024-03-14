using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        
        Console.Write("Enter number of numbers you want to generate: ");
        int n = Convert.ToInt32(Console.ReadLine());
    
        int[] randomNumbers = new int[n];
        
        // Generate and save random numbers in the array
        for (int i = 0; i < n; i++)
        {
            randomNumbers[i] = rnd.Next(10000, 100000); // Generate a 5 digit random number
        }
        
        // Print the random numbers stored in the array with spaces between their digits
        
        foreach (int number in randomNumbers)
        {
            Console.Write("  ");
            PrintNumberWithSpaces(number);
        }
        
        // Calculate the sum of all random numbers
        int sum = 0;
        foreach (int number in randomNumbers)
        {
            sum += number;
        }
        
        // Imprimir la suma con espacios entre sus dígitos
        Console.WriteLine("\nPress enter to know the addtion result:");
        Console.ReadKey(true);
        PrintNumberWithSpaces(sum);
    }
    
    // Method to print a number with spaces between its digits
    static void PrintNumberWithSpaces(int number)
    {
        string numberString = number.ToString();
        foreach (char digit in numberString)
        {
            Console.Write(digit + " ");
        }
        Console.WriteLine(); 
    }
}