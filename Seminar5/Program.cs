int[] getRandomArray(int lenght, int minValue, int maxValue)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(minValue, maxValue + 1);
    }
    return array;
}

int sumOfElements(int[] array, bool isSumPositive)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 && isSumPositive)
        {
            sum += array[i];
        }
        else if (array[i] < 0 && !isSumPositive)
        {
            sum += array[i];
        }
    }
    return sum;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// int[] arr = getRandomArray(12, -9, 9);
// printArray(arr);
// int sumPositive = sumOfElements(arr, true);
// int sumNegative = sumOfElements(arr, false);
// Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");


//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
//и наоборот.

void reverseArrayElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

// int[] array = getRandomArray(9, -100, 100);
// printArray(array);
// reverseArrayElements(array);
// printArray(array);


//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool FindNumberInArray(int[] array, int search)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == search)
        {
            return true;
        }
    }
    return false;
}

// int[] arr = getRandomArray(10, 0, 10);
// printArray(arr);
// Console.WriteLine(FindNumberInArray(arr, 5));

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int findElementOfRange(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        {
            count++;
        }
    }
    return count;
}

// int[] myArray = getRandomArray(123, int.MinValue, int.MaxValue);
// int count = findElementOfRange(myArray, 10, 99);
// Console.WriteLine(count);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] productOfArrayElementPairs(int[] array)
{
    int[] arr = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        arr[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1)
    {
        arr[arr.Length - 1] = array[array.Length / 2 ];
    }
    return arr;
}

int[] oldArray = getRandomArray(8, 0, 10);
printArray(oldArray);
int[] newArray = productOfArrayElementPairs(oldArray);
printArray(newArray);