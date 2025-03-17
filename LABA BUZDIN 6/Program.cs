using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        // 1. Заполнение массива ростов 12 человек
        int[] heights = new int[12];
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = rnd.Next(163, 191);
        }
        Console.WriteLine("Рост 12 человек: " + string.Join(", ", heights));

        // 2. Арифметическая прогрессия
        int A = 5, P = 3;
        int[] progression = new int[10];
        for (int i = 0; i < progression.Length; i++)
        {
            progression[i] = A + i * P;
        }
        Console.WriteLine("Арифметическая прогрессия: " + string.Join(", ", progression));

        // 3. 20 первых натуральных чисел, делящихся на 13 или 17, начиная с 300
        int[] divisibleNumbers = new int[20];
        int num = 300, count = 0;
        while (count < 20)
        {
            if (num % 13 == 0 || num % 17 == 0)
            {
                divisibleNumbers[count++] = num;
            }
            num++;
        }
        Console.WriteLine("Числа, делящиеся на 13 или 17: " + string.Join(", ", divisibleNumbers));

        // 4. Найти минимальный элемент массива
        int minElement = heights[0];
        foreach (int h in heights)
        {
            if (h < minElement) minElement = h;
        }
        Console.WriteLine("Минимальный элемент массива: " + minElement);

        // 5. Из всех положительных элементов вычесть k[1], из отрицательных - n
        double[] realNumbers = { 1.5, -3.2, 0, 4.8, -1.1, 5.6, -7.4 };
        double k1 = realNumbers[1], n = 2.0;
        for (int i = 0; i < realNumbers.Length; i++)
        {
            if (realNumbers[i] > 0) realNumbers[i] -= k1;
            else if (realNumbers[i] < 0) realNumbers[i] -= n;
        }
        Console.WriteLine("Обработанный массив: " + string.Join(", ", realNumbers));

       
    }
}
