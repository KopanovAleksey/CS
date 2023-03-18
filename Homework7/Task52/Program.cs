//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

double[] avarageOfMatrixColumns(int[,] matrix)
{
    double [] avarage = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {   
        double sum = 0;
        for (int j= 0; j< matrix.GetLength(0);j++)
        {
            sum += matrix[i,j]; 
        }
        avarage[i] = Math.Round(sum/matrix.GetLength(0), 1);
    }
    return avarage;
}

void Task52()
{
    int[,] matr = getRandomMatrix(6,6,0,9);
    PrintMatrix(matr);
    Console.WriteLine();
    double[] avr = avarageOfMatrixColumns(matr);
    Console.WriteLine(string.Join(" | ", avr));
}

Task52();