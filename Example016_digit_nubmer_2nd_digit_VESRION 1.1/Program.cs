using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трехзначное число:");
        
        // Ввод трехзначного числа
        string input = Console.ReadLine();

        // Проверка на корректность ввода
        if (input.Length == 3 && int.TryParse(input, out int number))
        {
            // Вычисление суммы цифр
            int digit1 = number / 100;
            int digit2 = (number % 100) / 10;
            int digit3 = number % 10;

            

            // Вывод результата
            Console.WriteLine($"Число по середине: {digit2}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите трехзначное число.");
        }
    }
}