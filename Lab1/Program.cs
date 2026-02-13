using System;

namespace Lab1_Variant5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Лабораторная работа 1. Вариант 5");
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1. Вычисление площади трапеции");
                Console.WriteLine("2. Вычисление средней линии трапеции");
                Console.WriteLine("3. Вычисление периметра равнобедренной трапеции");
                Console.WriteLine("0. Выход");
                Console.Write("\nВаш выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("\nОшибка: неверный выбор. Попробуйте снова.");
                        Console.WriteLine("Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Задача 1: Площадь трапеции
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задача 1: Вычисление площади трапеции");
            Console.WriteLine("Формула: S = (a + b) * h / 2\n");

            double baseA = ReadPositiveNumber("Введите основание a: ");
            double baseB = ReadPositiveNumber("Введите основание b: ");
            double height = ReadPositiveNumber("Введите высоту h: ");

            double area = (baseA + baseB) * height / 2;

            Console.WriteLine($"\nРезультат: Площадь трапеции S = {area:F2}");
            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }

        // Задача 2: Средняя линия трапеции
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Задача 2: Вычисление средней линии трапеции");
            Console.WriteLine("Формула: m = (a + b) / 2\n");

            double baseA = ReadPositiveNumber("Введите основание a: ");
            double baseB = ReadPositiveNumber("Введите основание b: ");

            double midline = (baseA + baseB) / 2;

            Console.WriteLine($"\nРезультат: Средняя линия трапеции m = {midline:F2}");
            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }

        // Задача 3: Периметр равнобедренной трапеции
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Задача 3: Вычисление периметра равнобедренной трапеции");
            Console.WriteLine("Формула боковой стороны: c = sqrt(h^2 + ((a-b)/2)^2)");
            Console.WriteLine("Формула периметра: P = a + b + 2c\n");

            double baseA = ReadPositiveNumber("Введите основание a: ");
            double baseB = ReadPositiveNumber("Введите основание b: ");
            double height = ReadPositiveNumber("Введите высоту h: ");

            double lateralSide = Math.Sqrt(height * height + Math.Pow((baseA - baseB) / 2, 2));
            double perimeter = baseA + baseB + 2 * lateralSide;

            Console.WriteLine($"\nБоковая сторона c = {lateralSide:F2}");
            Console.WriteLine($"Периметр трапеции P = {perimeter:F2}");
            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }

        // Функция для чтения положительного числа с проверкой на ошибки
        static double ReadPositiveNumber(string prompt)
        {
            double number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out number))
                {
                    if (number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: число должно быть положительным. Попробуйте снова.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное число. Попробуйте снова.");
                }
            }
        }
    }
}
