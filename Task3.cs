using System;

class Task3
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        int M = Convert.ToInt32(Console.ReadLine());
        int T = Convert.ToInt32(Console.ReadLine());

        int all = N * 60 + M + T;
        int hours = all / 60;
        int min = all % 60;
        hours = hours % 24;

        Console.WriteLine(hours + ":" + min);
    }
}