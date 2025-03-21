using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            // Шаг 1: Запрашиваем число у пользователя
            Console.WriteLine("Введите число: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Шаг 2: Запускаем цикл for от 1 до 10
            for (int i = 0; i <= userInput; i++)
            {
                int result = i + 1;
                
                // Шаг 4: Выводим результат на экран
                Console.WriteLine($" {result}");
            }
        }
    }
}
