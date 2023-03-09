int ReadIntNumber(string messageToUser)
{
    Console.Write(messageToUser + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

float Pow(int number, int power)
{
    float result = 1;
    if (power >= 0)
    {
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }
    } else
    {
        for (int i = -1; i >= power; i--)
        {
            result /= number;
        }
    }
    return result;
}

float result = Pow(ReadIntNumber("Введите число"), ReadIntNumber("Введите степень"));
Console.WriteLine(result);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int a = ReadIntNumber("Введите число и узнаете сумму его цифр");
Console.WriteLine(SumOfDigits(a));


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void fillArray(int[] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(minValue, maxValue + 1);
    }
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] arr = new int[8];
int min = ReadIntNumber("Введите начальное значение диапазона чисел");
int max = ReadIntNumber("Введите конечное значение диапазона чисел");
fillArray(arr, min, max);
printArray(arr);
