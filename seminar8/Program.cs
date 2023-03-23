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

//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void reverseMatrixRows(int[,] matrix, int row1, int row2)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[row1, i];
        matrix[row1, i] = matrix[row2, i];
        matrix[row2, i] = temp;
    }
}
//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
int[,] reverseRowsToColumns(int[,] matrix)
{
    int[,] reverseMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            reverseMatrix[j, i] = matrix[i, j];
        }
    }
    return reverseMatrix;
}
void reverseRowsToColumnsEqual(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Элементы [0, 9]
void printFrequencyDictionary(int[,] matrix, int minNumber, int maxNumber)
{
    for (int k = minNumber; k <= maxNumber; k++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == k) count++;
            }
        }
        if (count != 0) Console.WriteLine($"{k} встречается {count} раз");
    }
}
// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
int[] findMinimalElement(int[,] matrix)
{
    int[] minCoordinates = new int[2];
    minCoordinates[0] = 0;
    minCoordinates[1] = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minCoordinates[0], minCoordinates[1]])
            {
                minCoordinates[0] = i;
                minCoordinates[1] = j;
            }
        }
    }
    return minCoordinates;
}

int[,] deleteMinimalRowAndColumn(int[,] matrix)
{
    int[] coordinates = findMinimalElement(matrix);
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int newMatrixRow = 0;
    int newMatrixCoulumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != coordinates[0] && j != coordinates[1])
            {
                newMatrix[newMatrixRow, newMatrixCoulumn] = matrix[i, j];
                newMatrixCoulumn++;
            }
        }
        if (i != coordinates[0])
        {
            newMatrixRow++;
        }
        newMatrixCoulumn = 0;
    }
    return newMatrix;
}
void main()
{
    int[,] matr = getRandomMatrix(4, 4, 0, 9) /*{ { 3, 2, 3 }, { 4, 6, 1 }, { 7, 8, 9 } }*/;
    PrintMatrix(matr);
    Console.WriteLine();
    // reverseMatrixRows(matr, 4, 5);
    // int[,] matr1 = reverseRowsToColumns(matr);
    // reverseRowsToColumnsEqual(matr);
    // PrintMatrix(matr);
    // printFrequencyDictionary(matr, 0, 9);
    Console.WriteLine(string.Join(" ", findMinimalElement(matr)));
    PrintMatrix(deleteMinimalRowAndColumn(matr));
}

main();