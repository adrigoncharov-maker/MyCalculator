public class App
{
    public static void Main()
    {
        double num1 = ReadNumber("Введите первое число: ");

        Console.WriteLine("Введите знак: ");
        string operation = (Console.ReadLine() ?? string.Empty).Trim();

        if (operation == "sqrt")
        {
            Console.WriteLine(num1 < 0
                ? "Ошибка: нельзя извлечь корень из отрицательного числа"
                : $"Результат: {Math.Sqrt(num1)}");
            return;
        }

        double num2 = ReadNumber("Введите второе число: ");

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Результат: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Результат: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Результат: {num1 * num2}");
                break;
            case "/":
                Console.WriteLine(num2 != 0
                    ? $"Результат: {num1 / num2}"
                    : "Ошибка: на 0 делить нельзя");
                break;
            case "^":
                Console.WriteLine($"Результат: {Math.Pow(num1, num2)}");
                break;
            default:
                Console.WriteLine("Ошибка: неизвестная операция");
                break;
        }
    }

    private static double ReadNumber(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                return value;
            }
            Console.WriteLine("Ошибка: введите корректное число");
        }
    }
}
