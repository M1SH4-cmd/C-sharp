using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трёхзначное число:");
        string input = Console.ReadLine();

        if (IsThreeDigitNumber(input))
        {
            char middleDigit = GetMiddleDigit(input);
            Console.WriteLine($"Число по середине: {middleDigit}");
        }
        else
        {
            Console.WriteLine("Число не трёхзначное.");
        }
    }

    static bool IsThreeDigitNumber(string input)
    {
        return input.Length == 3 && int.TryParse(input, out _);
    }

    static char GetMiddleDigit(string input)
    {
        int middleIndex = input.Length / 2;
        return input[middleIndex];
    }
}