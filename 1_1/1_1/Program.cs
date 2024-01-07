using System;

class Program
{
    static void Main()
    {
       Console.Write("Введите число a= : ");
        int number = int.Parse(Console.ReadLine());

        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine($"a={number}   => да");
        }
        else
        {
            Console.WriteLine($"a={number}   => нет");
        }
    }
}

