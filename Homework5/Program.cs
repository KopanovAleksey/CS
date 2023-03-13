// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] getRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(min, max + 1);
    }
    return array;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int findEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// int[] array = getRandomArray(10,0, int.MaxValue-1);
// printArray(array);
// int countOfEven = findEven(array);
// Console.WriteLine(countOfEven);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int sumOfOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

// int[] arr = getRandomArray(11, 0, 10);
// printArray(arr);
// int sumOfOdd = sumOfOddPosition(arr);
// Console.WriteLine(sumOfOdd);

// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int diffMaxFromMin(int[] array)
{
    int max = 0;
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[max] < array[i]) max = i;
        if (array[min] > array[i]) min = i;
    }
    int diff = array[max] - array[min];
    return diff;
}

int[] newArray = getRandomArray(10, -100, 100);
printArray(newArray);
Console.WriteLine(diffMaxFromMin(newArray));
*/