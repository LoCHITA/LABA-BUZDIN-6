using System;

class Program
{
    static void Main()
    {
        for (; ; )
        {
            Console.WriteLine("Часть - ");
            double vc = Convert.ToDouble(Console.ReadLine());
            switch (vc)
            {
                case 1:
                    for (int ii = 0; ii < 7; ii++)
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
                break;
               case 2:
                    for (int ii = 0; ii < 7; ii++)
                    {
                        Console.WriteLine("Введите номер задания");
                        double vz = Convert.ToDouble(Console.ReadLine());
                        switch (vz)
                        {
                            case 1:
                                //1. Найти максимальный элемент матрицы
                                Console.Write("Введите количество строк");
                                int ksto = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите количество столбцов");
                                int kstr = Convert.ToInt32(Console.ReadLine());
                                int[,] matrix = new int[ksto, kstr];
                                Console.WriteLine("Введите элементы матрицы");
                                for (int i = 0; i < ksto; i++)
                                {
                                    for (int j = 0; j < kstr; j++)
                                    {
                                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                                int maxel = matrix[0, 0];
                                for (int i = 0; i < ksto; i++)
                                {
                                    for (int j = 0; j < kstr; j++)
                                    {
                                        if (matrix[i, j] > maxel)
                                        {
                                            maxel = matrix[i, j];
                                        }
                                    }
                                }
                                Console.WriteLine($"Максимальный элемент матрицы - {maxel}");
                                break;
                            case 2:
                                //2. найти сумму столбцов матрицы
                                Console.Write("Введите количество строк");
                                int ksto2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите количество столбцов");
                                int kstr2 = Convert.ToInt32(Console.ReadLine());
                                int[,] matrix2 = new int[ksto2, kstr2];
                                Console.WriteLine("Введите элементы матрицы");
                                for (int i = 0; i < ksto2; i++)
                                {
                                    for (int j = 0; j < kstr2; j++)
                                    {
                                        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                                for (int j = 0; j < ksto2; j++)
                                {
                                    int sum = 0;
                                    for (int i = 0; i < kstr2; i++)
                                    {
                                        sum += matrix2[i, j];
                                    }
                                    Console.WriteLine($"Сумма столбца {j + 1} = {sum}");
                                }
                                break;
                            case 3:
                                //3. найти сумму элементов побочной диагонали квадратной матрицы
                                Console.Write("Введите количество строк");
                                int ksto3 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите количество столбцов");
                                int kstr3 = Convert.ToInt32(Console.ReadLine());
                                int[,] matrix3 = new int[ksto3, kstr3];
                                Console.WriteLine("Введите элементы матрицы");
                                for (int i = 0; i < ksto3; i++)
                                {
                                    for (int j = 0; j < kstr3; j++)
                                    {
                                        matrix3[i, j] = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                                if (ksto3 == kstr3)
                                {
                                    int sumd = 0;
                                    for ( int i = 0;i < kstr3; i++)
                                    {
                                        sumd += matrix3[i, kstr3 - 1 - i];
                                    }
                                    Console.WriteLine($"Сумма элементов побочной диагонали - {sumd}");
                                }
                                else
                                {
                                    Console.WriteLine("Матрица не квадратная");
                                }
                                break;
                            case 4:
                                //4. Найти количество положительных четных элементов произвольной матрицы
                                Console.Write("Введите количество строк");
                                int ksto4 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите количество столбцов");
                                int kstr4 = Convert.ToInt32(Console.ReadLine());
                                int[,] matrix4 = new int[ksto4, kstr4];
                                Console.WriteLine("Введите элементы матрицы");
                                for (int i = 0; i < ksto4; i++)
                                {
                                    for (int j = 0; j < kstr4; j++)
                                    {
                                        matrix4[i, j] = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                                int colch = 0;
                                for (int i = 0; i < ksto4; i++)
                                {
                                    for (int j = 0; j < kstr4; j++)
                                    {
                                        if (matrix4[i, j] > 0 && matrix4[i, j] %2 == 0)
                                        {
                                            colch++;
                                        }
                                    }
                                }
                                Console.WriteLine($"Количество положительных четных элементов - {colch}");
                                break;
                            case 5:
                                //5. Подсчитать количество строк содержащих отрицательные элементы
                                Console.Write("Введите количество строк");
                                int ksto5 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите количество столбцов");
                                int kstr5 = Convert.ToInt32(Console.ReadLine());
                                int[,] matrix5 = new int[ksto5, kstr5];
                                Console.WriteLine("Введите элементы матрицы");
                                for (int i = 0; i < ksto5; i++)
                                {
                                    for (int j = 0; j < kstr5; j++)
                                    {
                                        matrix5[i, j] = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                                int colotr = 0;
                                for (int i = 0;i < ksto5; i++)
                                {
                                    bool neg = false;
                                    for (int j = 0;j < kstr5; j++)
                                    {
                                        if (matrix5[i, j] < 0)
                                        {
                                            neg = true;
                                        }
                                    }
                                    if (neg)
                                    {
                                        colotr++;
                                    }
                                }
                                Console.WriteLine($"Количество строк содержащих отрицательные элементы - {colotr}");
                                break;
                            case 6:
                                //6. Найти максимальные элементы во всех столбцах матрицы
                                Console.Write("Введите количество строк");
                                int ksto6 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите количество столбцов");
                                int kstr6 = Convert.ToInt32(Console.ReadLine());
                                int[,] matrix6 = new int[ksto6, kstr6];
                                Console.WriteLine("Введите элементы матрицы");
                                for (int i = 0; i < ksto6; i++)
                                {
                                    for (int j = 0; j < kstr6; j++)
                                    {
                                        matrix6[i, j] = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                                for (int j = 0;j < kstr6 ; j++)
                                {
                                    int maxstr = matrix6[0, j];
                                    for (int i = 1; i < ksto6 ; i++)
                                    {
                                        if (matrix6[i, j] > maxstr)
                                        {
                                            maxstr = matrix6[i, j];
                                        }
                                    }
                                    Console.WriteLine($"Максимальный элемент в столбце {j + 1} - {maxstr}");
                                }
                                break;
                            case 7:
                                //7. Найти номер первой строки, содержащей максимальный элемент в матрице
                                Console.Write("Введите количество строк");
                                int ksto7 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Введите количество столбцов");
                                int kstr7 = Convert.ToInt32(Console.ReadLine());
                                int[,] matrix7 = new int[ksto7, kstr7];
                                Console.WriteLine("Введите элементы матрицы");
                                for (int i = 0; i < ksto7; i++)
                                {
                                    for (int j = 0; j < kstr7; j++)
                                    {
                                        matrix7[i, j] = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                                int firstmax = -1;
                                int maxel7 = matrix7[0, 0];
                                for (int i = 0; i < ksto7; i++)
                                {
                                    for (int j = 0; j < kstr7; j++)
                                    {
                                        if (matrix7[i, j] > maxel7)
                                        {
                                            maxel = matrix7[i, j];
                                        }
                                    }
                                }
                                for (int i = 0; i < ksto7; i++)
                                {
                                    if (matrix7[i, 0]== maxel7)
                                    {
                                        firstmax = i + 1;
                                    }
                                    for (int j = 1; j < ksto7; j++)
                                    {
                                        if (matrix7[i, j] == maxel7)
                                        {
                                            firstmax = i + 1;
                                        }
                                    }
                                    if (firstmax != -1)
                                        break;
                                    
                                }
                                if (firstmax != -1)
                                {
                                    Console.WriteLine($"Первая строка, содержащая максимальный элемент - {firstmax}");
                                }
                                else
                                {
                                    Console.WriteLine("Максимальный элемент не найден");
                                }
                                break;
                        }
                    }
                    break;

                        

            }             

        }
    }
}
