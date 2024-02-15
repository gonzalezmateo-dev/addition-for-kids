Random rnd = new Random();
String rndNumber;
int result = 0;
String sumando = " ";

Console.WriteLine("\n Solve addition:");

// Show random numbers
for (int i = 0; i < 5; i++)
{
    Console.Write("\n ");
    for (int j = 0; j < 5; j++)
    {
        rndNumber = rnd.Next(1,10).ToString();
        sumando += rndNumber;
        Console.Write(" " + rndNumber);
    }
    result += Int32.Parse(sumando);
    sumando = "";
    

}

// Separate numbers
// result mod 10 because 255 = 2*100 + 5 * 10 + 5
int[] numAr = {0, 0, 0, 0, 0, 0};
int cont = 5;
while(result > 0){   
    numAr[cont] = result % 10;
    cont--;
    result /= 10;
}

// Print orderned numbers 
Console.WriteLine("\n\nPress any key to continue . . . ");
Console.ReadKey(true);

Console.WriteLine(" -----------");
foreach(int k in numAr){
    Console.Write(k+" ");
}
