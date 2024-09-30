//Задача 1: Вывод натуральных чисел в промежутке от M до N
//Описание: Напишите программу, которая выведет все натуральные числа в
//промежутке от M до N. Используйте рекурсию и не используйте циклы.
using System;
class MyClass
{
    public static void Main()
    {
        // Запрос и получение исходных данных
        // Проверка на корректность ввода не провидится. Считаем, что ввод всегда корректный
        Console.WriteLine("Введите начало диапазона чисел.");
        int start = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите конец диапазона.");
        int stop = Int32.Parse(Console.ReadLine());

        ShowRangeOfDigits(start, stop);

    }

    static void ShowRangeOfDigits(int start, int stop)
    {
        if (start <= stop)
        {
            Console.Write(start);
            if (start < stop) Console.Write(", ");
            ShowRangeOfDigits(start + 1, stop);
        }
    }
}