using System;

class Program
{
    // Рекурсивний метод для обчислення суми елементів масиву
    static int RecursiveSum(int[] arr, int index)
    {
        if (index < 0)
            return 0;
        return arr[index] + RecursiveSum(arr, index - 1);
    }

    // Рекурсивний метод для підрахунку кількості додатних елементів
    static int RecursiveCountPositive(int[] arr, int index)
    {
        if (index < 0)
            return 0;
        int current = arr[index] > 0 ? 1 : 0;
        return current + RecursiveCountPositive(arr, index - 1);
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] array = { -4, 12, 0, 7, -9, 3, 15, -2 };

        Console.WriteLine("Масив: " + string.Join(", ", array));
        Console.WriteLine("Сума елементів масиву (рекурсивно): " + RecursiveSum(array, array.Length - 1));
        Console.WriteLine("Кількість додатних елементів (рекурсивно): " + RecursiveCountPositive(array, array.Length - 1));
        Console.ReadLine();
    }
}