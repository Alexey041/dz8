/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();
int[,] array = new int[4, 4];

FillSpiral(array);
PrintArray(array);

void FillSpiral(int[,] array)
{
    int a = 1; int i = 0; int j = 0;
    int row = array.GetLength(0); int col = array.GetLength(1);
    for (int count = 0; count < array.GetLength(1) * array.GetLength(0); count++)
    {
        row--; col--;
        for (int right = 0; right < col; right++)
        {
            if ((j != col) & (array[i, j] == 0))
            {
                array[i,j] = a; a++; j++;
            }
        }
        for (int down = 0; down < row; down++)
        {
            if ((i != row) & (array[i,j] == 0))
            {
                array[i, j] = a; a++; i++;
            }
        }

        for (int left = 0; left < col; left++)
        {
            if ((j != 0) & (array[i,j] == 0))
            {
                array[i, j] = a; a++; j--;
            }
        }
                
        for (int up = 0; up < row; up++)
        {
            if ((i != 1) & (array[i,j] == 0))
            {
                array[i, j] = a; a++; i--;
            }
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

//Только 4х4. На больше ума не хватило((