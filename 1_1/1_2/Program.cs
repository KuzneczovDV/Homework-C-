using System;

class Program
{
    static void Main()
    {
       Console.WriteLine("Введите координаты X и Y через запятую с пробелом:");
       string[]coordinates = Console.ReadLine().Split(',');
       int x = Convert.ToInt32(coordinates[0]);
       int y = Convert.ToInt32(coordinates[1]);

        if (x > 0 && y > 0)
        {
            Console.WriteLine("=> 1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("=> 2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("=> 3");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("=> 4");
        }
        else
        {
            Console.WriteLine("Точка лежит на одной из координатных осей.");
        }
    }
}

