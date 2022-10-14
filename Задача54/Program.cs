/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Write("Введите число строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int coloumn = int.Parse(Console.ReadLine()!);
int[,] array = new int[row, coloumn];

FillArray(array);
PrintArray(array);
Console.WriteLine();
SortColoumn(array);
PrintArray(array);


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

void SortColoumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int r = 0; r < array.GetLength(1); r++)
            {
                for (int c = r + 1; c < array.GetLength(1); c++)
                {
                    if (array[i, r] < array[i, c])
                    {
                        int k = array[i, r];
                        array[i, r] = array[i, c];
                        array[i, c] = k;
                    }
                }
            }
        }
    }
    
}