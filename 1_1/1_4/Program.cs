using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Введите положительное натуральное число.");
            return;
        }

        Console.WriteLine($"{n}  => {string.Join(", ", GetDigits(n))}");
    }

    static int[] GetDigits(int number)
    {
        char[] charArray = number.ToString().ToCharArray();
        int[] digits = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));
        return digits;
    }
}
