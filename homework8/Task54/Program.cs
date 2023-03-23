// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
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

void bubbleSortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j + 1] < matrix[i, j])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
}

void insertionSortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 1; k < matrix.GetLength(1); k++)
        {
            for (int j = k; j > 0 && matrix[i, j - 1] > matrix[i, j]; j--)
            {
                int temp = matrix[i, j - 1];
                matrix[i, j - 1] = matrix[i, j];
                matrix[i, j] = temp;
            }
        }
    }
}

void main()
{
    int[,] matr = getRandomMatrix(6, 6, 0, 9);
    PrintMatrix(matr);
    Console.WriteLine();
    bubbleSortMatrix(matr);
    insertionSortMatrix(matr);
    PrintMatrix(matr);
}
main();