/* Задайте прямоугольный двумерный массив. Напишите программу, которая
будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка (нумерация строк начинается с 1) */

Console.Clear();
Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);
int[,] array = new int[row, coloumn];

FillArray(array);
PrintArray(array);
Console.WriteLine(SmallestString(array));

void FillArray(int[,] array)
{
    Random RandomGenerator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = RandomGenerator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"|{array[i, j]}|");
        }
        Console.WriteLine();
    }
}

int SumOfFirstString(int[,] array)
{
    int summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summ = summ + array[0, j];
    }
    return summ;
}

int SmallestString(int[,] array)
{
    int summString;
    int smallestSumm = SumOfFirstString(array);
    int indexOfSmallestString = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summString = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summString = summString + array[i, j];
            if (j == array.GetLength(1) - 1)
            {
                if (smallestSumm > summString)
                {
                    smallestSumm = summString;
                    indexOfSmallestString = i;
                }
            }
        }
    }
    return indexOfSmallestString + 1;
}