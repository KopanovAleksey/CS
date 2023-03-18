//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] getRandomMatrix(int rows, int columns, int leftBoarder, int rightBoarder)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(Random.Shared.NextDouble()*(rightBoarder-leftBoarder) + leftBoarder, 1);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
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

void Task47()
{
    double[,] matr = getRandomMatrix(5,5,0,1);
    PrintMatrix(matr); 
}
Task47();