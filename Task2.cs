using System;

class Task2
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int chis = Convert.ToInt32(Console.ReadLine());

        string s = "";

        while (chis > 0)
        {
            s = (chis % 2) + s;
            chis = chis / 2;
        }
        Console.WriteLine(s);
    }
}



