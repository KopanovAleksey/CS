//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
int[,] matrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplicationMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
    {
        Console.WriteLine("Введенные матрицы имеют разные размеры !");
        return multiplicationMatrix;
    }
    for (int i = 0; i < multiplicationMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiplicationMatrix.GetLength(1); j++)
        {
            multiplicationMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return multiplicationMatrix;
}

void main()
{
    int[,] matr1 = getRandomMatrix(3, 3, -9, -1);
    int[,] matr2 = getRandomMatrix(3, 3, 1, 9);
    PrintMatrix(matr1);
    Console.WriteLine();
    PrintMatrix(matr2);
    Console.WriteLine();
    PrintMatrix(matrixMultiplication(matr1, matr2));
    Console.WriteLine();   
}

main();