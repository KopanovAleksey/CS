//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int ReadIntNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumFrom1ToA(int a)
{
    int sum = 0;
    for(int i = 1; i<=a; i++)
    {
        sum+= i;
    }
    return sum;
}

int NumberOfDigits(int number)
{
    int i = 0;
    while ( number>0)
    {
        number /= 10;
        i++;
    }
    return i;
}

int MultiplyFrom1ToA(int a)
{
    int mult = 1;
    for(int i = 1; i<=a; i++)
    {
        mult*= i;
    }
    return mult;
}
*/
void printArray(int[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// int number = ReadIntNumber("Введите число A");
// int result = SumFrom1ToA(number);
// Console.WriteLine($"Сумма чисел от 1 до {number} = {result}"); 

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int number = ReadIntNumber("Введите число");
// int digits = NumberOfDigits(number);
// Console.WriteLine($"Количество цифр в числе {number} = {digits}");

//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int num = ReadIntNumber("Введите число A");
// int res = MultiplyFrom1ToA(num);
// Console.WriteLine($"Факториал числа {num} = {res}");

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] arr = new int[8];
for(int i = 0; i< arr.Length ; i++)
{
    arr[i] = Random.Shared.Next(0, 2);
}

printArray(arr);
