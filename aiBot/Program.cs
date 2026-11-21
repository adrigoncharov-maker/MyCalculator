using System;

public class App
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите знак: ");
        string operation = Console.ReadLine();

        Console.WriteLine("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (operation == "+")
        {
            Console.WriteLine($"Результат: {num1 + num2}");
        }
        else if (operation == "-")
        {
            Console.WriteLine($"Результат: {num1 - num2}");
        }
        else if (operation == "*")
        {
            Console.WriteLine($"Результат: {num1 * num2}");
        }
        else if (operation == "/")
        {
            Console.WriteLine($"Результат: {num1 / num2}");
        }
        if (num2 != 0)
        {
            Console.WriteLine($"Результат: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Ошибка: на 0 делить нельзя");
        }
    }
}