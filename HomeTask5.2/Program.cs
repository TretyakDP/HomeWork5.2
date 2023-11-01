using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Введена пустая или пробельная строка.");
        }
        else if (!input.Contains("h"))
        {
            Console.WriteLine("В строке нет символа 'h'.");
        }
        else
        {
            int firstHIndex = input.IndexOf("h");
            int lastHIndex = input.LastIndexOf("h");

            for (int i = 0; i < input.Length; i++)
            {
                if (i != firstHIndex && i != lastHIndex && input[i] == 'h')
                {
                    input = input.Remove(i, 1).Insert(i, "H");
                }
            }

            Console.WriteLine("Результат: " + input);
        }
    }
}
