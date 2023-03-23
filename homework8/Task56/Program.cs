//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
void numberOfRowWithMinimumSum(int[,] matrix)
{
    int[] minimalSum = new int[2];
    minimalSum[0] = Int32.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minimalSum[0])
        {
            minimalSum[0] = sum;
            minimalSum[1] = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов: {minimalSum[0]}, находится в ряду {minimalSum[1]}.");
}

void main()
{
    int[,] matr = getRandomMatrix(9,6,-20,20);
    PrintMatrix(matr);
    numberOfRowWithMinimumSum(matr);
}
main();