/*
using System;

class Prog
{
    static void Main()
    {
        Console.WriteLine("Введите 9 чисел:");
        string? input = Console.ReadLine();
        
        string[] numbers = input!.Split(' ', StringSplitOptions.RemoveEmptyEntries);


        int[,] original = new int[3, 3];
        int[,] result = new int[3, 3];

 
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                original[i, j] = Convert.ToInt32(numbers[index]);
                index++;
         }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
         {
                result[j, i] = original[i, j]; 
        }
        }

        Console.WriteLine("\nРезультат:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
}
}
*/