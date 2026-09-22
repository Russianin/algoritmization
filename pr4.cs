using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string text = Console.ReadLine();

        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
             if (i % 2 == 0)
             {
                result += char.ToUpper(text[i]);
            }
            else
            {
                result += text[i];
            }
        }

        Console.WriteLine("Результат: " + result);

        Console.Write("Введите число до 1000: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введите элемент " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 4; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}