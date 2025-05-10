using System;

class Program
{
    static void Main()
    {
        for (; ; )
        {
            Console.WriteLine("Введите номер задания");
            double vz = Convert.ToDouble(Console.ReadLine());
            switch (vz)
            {
                case 1:
                    Random rnd = new Random();

                    // 1. Заполнение массива ростов 12 человек
                    int[] heights = new int[12];
                    for (int i = 0; i < heights.Length; i++)
                    {
                        heights[i] = rnd.Next(163, 191);
                    }
                    Console.WriteLine("Рост 12 человек: " + string.Join(", ", heights));
                    break;
                case 2:
                    // 2. Арифметическая прогрессия
                    int A = 5, P = 3;
                    int[] progression = new int[10];
                    for (int i = 0; i < progression.Length; i++)
                    {
                        progression[i] = A + i * P;
                    }
                    Console.WriteLine("Арифметическая прогрессия: " + string.Join(", ", progression));
                    break;
                case 3:
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
                    break;
                case 4:
                    // 4. Найти минимальный элемент массива
                    Random rnd1 = new Random();
                    int[] height = new int[12];
                    int minElement = height[0];
                    foreach (int h in height)
                    {
                        if (h < minElement) minElement = h;
                    }
                    Console.WriteLine("Минимальный элемент массива: " + minElement);
                    break;
                case 5:
                    // 5. Из всех положительных элементов вычесть k[1], из отрицательных - n
                    double[] realNumbers = { 1.5, -3.2, 0, 4.8, -1.1, 5.6, -7.4 };
                    double k1 = realNumbers[1], n = 2.0;
                    for (int i = 0; i < realNumbers.Length; i++)
                    {
                        if (realNumbers[i] > 0) realNumbers[i] -= k1;
                        else if (realNumbers[i] < 0) realNumbers[i] -= n;
                    }
                    Console.WriteLine("Обработанный массив: " + string.Join(", ", realNumbers));
                    break;
                case 6:
                    // 6	Дан массив целых чисел. Все элементы, оканчивающиеся цифрой 4, уменьшить вдвое.
                    int[] numbers = { 14, 23, 34, 45, 54, 64, 74, 84, 94, 104 };
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        // Проверяем, оканчивается ли элемент на 4
                        if (numbers[i] % 10 == 4)
                        {
                            numbers[i] /= 2; // Уменьшаем элемент вдвое
                        }
                    }
                    Console.WriteLine("Модифицированный массив: " + string.Join(", ", numbers));
                    break;
                case 7:
                    // 7. Находим сумму и произведение всех элементов массива
                    int[] numbers1 = { 14, 23, 34, 45, 54, 64, 74, 84, 94, 104 };
                    int sum = 0; // Переменная для суммы
                    int product = 1; // Переменная для произведения

                    for (int i = 0; i < numbers1.Length; i++)
                    {
                        sum += numbers1[i]; // Добавляем текущий элемент к сумме
                        product *= numbers1[i]; // Умножаем текущий элемент на произведение
                    }
                    Console.WriteLine("Сумма всех элементов: " + sum);
                    Console.WriteLine("Произведение всех элементов: " + product);
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильное задание");
                    break;

            }

        }
    }
}
