using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число от [10, 99]:");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 10;
        int secondDigit = number % 10;
        
        int maxDigit = Math.Max(firstDigit, secondDigit);

        Console.WriteLine($"{number}  => {maxDigit}");
    }
}
