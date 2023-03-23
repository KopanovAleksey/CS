// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] get3DMatrix(int rows, int columns, int levels)
{
    int[,,] matrix = new int[rows, columns, levels];
    int n = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = n++;
            }
        }
    }
    return matrix;
}

void print3DMatrixElements(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("| ");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]} ({i},{j},{k}) | ");
            }
            Console.WriteLine();
        }
    }
}
void main()
{
    int[,,] cube = get3DMatrix(3,3,3);
    print3DMatrixElements(cube);
}

main();