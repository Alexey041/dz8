
int[,] ar1 = new int[,] {{1, 2, 3},
                         {3, 4, 5}};

int[,] ar2 = new int[,] {{5, 6, 1},
                         {8, 9, 2},
                         {1, 4, 3}};

PrintArray(MatrixSum(ar1, ar2));

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


int[,] MatrixSum(int[,] ar1, int[,] ar2)
{
    int[,] ar3 = new int[ar1.GetLength(0), ar2.GetLength(1)];
    for (int i = 0; i < ar1.GetLength(0); i++)
    {
        for (int j = 0; j < ar2.GetLength(1); j++)
        {
            for (int k = 0; k < ar2.GetLength(1); k++)
            {
                ar3[i, j] += ar1[i, k] * ar2[k, j];
            }
        }
    }
    return ar3;
}

