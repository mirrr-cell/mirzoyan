
/*
using System;
class Program
{
    static void Main(string[] args)
    {
    Console.Write("Ко-во студентов: ");
    int k = int.Parse(Console.ReadLine());
    Console.Write("Кол-во предметов: ");
    int m = int.Parse(Console.ReadLine());

    int[,] grades = new int[k, m];

    for (int i = 0; i < k; i++)
    {
    Console.WriteLine($"студкент{i + 1}:");
    for (int j = 0; j < m; j++)
        {
        Console.Write($"Оценка по предмету{j + 1}:");
    grades[i, j] = int.Parse(Console.ReadLine());
}
}

  Console.WriteLine("Средние оценки:");
    for (int i = 0; i < k; i++)
{
    double sum = 0;
    for (int j = 0; j < m; j++)
    sum += grades[i, j];
    Console.WriteLine($"Студент {i + 1}: {sum / m:F2}");
}
}
}
*/