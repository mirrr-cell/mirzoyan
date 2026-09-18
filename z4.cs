
/*
using System;
class Program
{
    static void Main()
{
    Dictionary<string, string> contacts = new Dictionary<string, string>();

    while (true)
    {
    Console.Write("команда (добавить/найти/просмотр/выход): ");
    string cmd = Console.ReadLine().ToLower();

    if (cmd == "выход")
    {

    Console.WriteLine("пока.");
            break;

    }

    else if (cmd == "добавить")

    {
        Console.Write("Имя: ");
    string name = Console.ReadLine();
        Console.Write("Номер: ");

    string phone = Console.ReadLine();
    contacts[name] = phone;
        Console.WriteLine("контакт добавлен.");

    }
    else if (cmd == "найти")
    {
    Console.Write("имя для поиска: ");
    string name = Console.ReadLine();

    if (contacts.ContainsKey(name))

        Console.WriteLine($"{name}: {contacts[name]}");
    else
        Console.WriteLine("контакт не найден.");
        }
    else if (cmd == "просмотр")
        {
    if (contacts.Count == 0)
        Console.WriteLine("справочник пуст.");
    else
        foreach (var kv in contacts)
        Console.WriteLine($"{kv.Key}: {kv.Value}");
    }
    else
    {
        Console.WriteLine("неизвестная команда.");
    }
   }
}
}
*/