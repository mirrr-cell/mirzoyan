
/*
using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine() ?? "0");
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}:");
            a[i] = int.Parse(Console.ReadLine() ?? "0"); 
        }

        Console.WriteLine("Обратно:");

        for (int i = n - 1; i >= 0; i--) 
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine(); 

        double avg = a.Average();
        Console.WriteLine("Среднее: " + avg);
        
        int clos = a.OrderBy(x => Math.Abs(x - avg)).First();

        Console.WriteLine($"ближайшее к среднему: {clos}"); 
             }  
}
*/