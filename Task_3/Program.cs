// Задача 3: Вывод элементов массива в обратном порядке
// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.
using System;
public class Answer
{
    public static void PrintArrayReverse(int[] array)
    {
        if (array.Length > 1)
        {
            Console.Write(array[^1] + ", ");
            PrintArrayReverse(array[..^1]);
        }
        else
        {
            Console.WriteLine(array[0]);
        }
    }
    static public void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 }; // Можно поменять значение для проверки
        Console.WriteLine("Массив в прямом порядке"); // Массив в прямом порядке
        ShowArray(array);                

        Console.WriteLine("Массив в обратном порядке:");
        PrintArrayReverse(array);
    }

    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1) Console.Write(", ");
        }
        Console.WriteLine();
    }
}