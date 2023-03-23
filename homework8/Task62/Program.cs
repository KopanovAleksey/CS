// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
/*
1   2  3 4
12 13 14 5
11 16 15 6
10  9  8 7
*/
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}

int[,] fillMatrixSpirally(int rows, int coulumns)
{
    int n = 1;
    int i = 0;
    int j = 0;
    int[,] array = new int[rows, coulumns];
    for (int k = 0; k < rows; k++)
    {
        if (i == k && j == k)
        {
            while (j < array.GetLength(1) - 1 - k && array[i, j] == 0)
            {
                array[i, j++] = n++;
            }
        }
        if (i == k && j == array.GetLength(1) - 1 - k)
        {
            while (i < array.GetLength(0) - 1 - k && array[i, j] == 0)
            {
                array[i++, j] = n++;
            }
        }
        if (i == array.GetLength(0) - 1 - k && j == array.GetLength(1) - 1 - k)
        {
            while (j > k && array[i, j] == 0)
            {
                array[i, j--] = n++;
            }
        }
        if (i == array.GetLength(0) - 1 - k && j == k)
        {
            while (i > k && array[i, j] == 0)
            {
                array[i--, j] = n++;
            }
        }
        i += 1;
        j += 1;
    }
    if(array[array.GetLength(0)/2, array.GetLength(1)/2] == 0)
    {
        array[array.GetLength(0)/2, array.GetLength(1)/2] = n;
    }
    return array;
}
void Main()
{
    int[,] matrix = fillMatrixSpirally(9, 9);
    PrintMatrix(matrix);
}
Main();
