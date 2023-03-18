//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int getElementCoordinates(string text)
{
    Console.Write($"Введите номер {text} искомого элемента: ");
    return Convert.ToInt32(Console.ReadLine());
}

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
void checkMatrixElement(int[,] matrix, int row, int column)
{
    if ((matrix.GetLength(0) <= row || row < 0)
        || (matrix.GetLength(1) <= column || column < 0))
    {
        Console.WriteLine("Элемента по заданным координатам в матрице не существует");
    }
    else
    {
        Console.WriteLine($"Элемент матрицы с координатами [{row};{column}] = {matrix[row, column]}");
    }
}
void Task50()
{
    int[,] matrix = getRandomMatrix(5, 5, 0, 9);
    PrintMatrix(matrix);
    int row = getElementCoordinates("строки");
    int column = getElementCoordinates("столбца");
    checkMatrixElement(matrix, row, column);
}

Task50();