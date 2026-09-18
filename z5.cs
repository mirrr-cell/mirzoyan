using System;

class Program
{
    static void Main()
    {
    Dictionary<string, int> counter = new Dictionary<string, int>();

    while (true)
    {
    Console.Write("Введите слово: ");
    string word = Console.ReadLine().ToLower();

    if (word == "стоп") break;

    if (counter.ContainsKey(word))
        counter[word]++;
    else
        counter[word] = 1;


    Console.Write("словарь: { ");
    foreach (var kv in counter)

    Console.Write($"{kv.Key}:{kv.Value} ");

    Console.WriteLine("}");
        }
    }
}