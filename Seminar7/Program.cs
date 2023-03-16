int[,] getRandomMatrix(int rows, int columns, int leftBoarder, int rightBoarder)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBoarder, rightBoarder + 1);
        }
    }
    return matrix;
}

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
int[,] getMatrix(int rows, int columns, int leftBoarder, int rightBoarder)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}
void matrixOddPow(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}
int sumOfMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}
void PrintMatrixZeroExeption(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0) Console.Write($"{matrix[i, j]}");
            else Console.Write($" ");
        }
        Console.WriteLine();
    }
}

int[,] PascalTriangular(int rows)
{
    int[,] matrix = new int[rows / 2, rows + 1];
    matrix[0, rows / 2] = 1;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i - 1, j - 1] != 0 || matrix[i - 1, j + 1] != 0)
            {
                matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
            }
        }
    }
    return matrix;
}

void Main()
{
    //Задача 46
    // int[,] matr = getRandomMatrix(5, 6, 0, 9);
    // PrintMatrix(matr);

    // Задача 48: Задайте двумерный массив размера m на n, 
    // каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
    // int[,] matr1 = getMatrix(5, 6, 0, 9);
    // PrintMatrix(matr1);

    // Задача 49: Задайте двумерный массив. 
    // Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
    // int[,] matr2 = getRandomMatrix(3, 4, 2, 3);
    // PrintMatrix(matr2);
    // Console.WriteLine();
    // matrixOddPow(matr2);
    // PrintMatrix(matr2);

    // Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
    // находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
    // int[,] matr3 = getRandomMatrix(6, 6, 0, 3);
    // PrintMatrix(matr3);
    // int sum = sumOfMainDiagonal(matr3);
    // Console.WriteLine(sum);

    // Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
    int[,] matr = PascalTriangular(15);
    PrintMatrixZeroExeption(matr);

}

Main();