using System;

class Task1
{
    static void Main()
    {
        Console.Write("Введите двоичное число: ");
        string s = Console.ReadLine();

        int result = 0;
        int stepen = 1;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '1')
            {
                result = result + stepen;
            }
            stepen = stepen * 2;
        }

        Console.WriteLine(result);
    }
}