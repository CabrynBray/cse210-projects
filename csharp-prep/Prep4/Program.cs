using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.Write("Enter a list of numbers, type 0 when finished.");
        
        List<int> NumList = new List<int>();

        int number = -1;

        while (number != 0)
        {
            
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            
            if (number != 0)
            {
                NumList.Add(number);
            }
        } 

        int sum = 0;
        foreach (int Num in NumList)
        {
            sum += Num;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = sum / NumList.Count; 
        Console.WriteLine($"The average is: {average}");

        int maxNum = NumList[0];
        foreach (int Num in NumList)
        {
            if (Num > maxNum)
            {
                maxNum = number;
            } 
        }
        Console.WriteLine($"The max is: {maxNum}");


    }
}