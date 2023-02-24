//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

/*
Console.WriteLine("Введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Число " + num1 + " больше числа " + num2);
}
else if (num2 > num1)
{
    Console.WriteLine("Число " + num2 + " больше числа " + num1);
}
else
{
    Console.WriteLine("Числа равны");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

/*
Console.WriteLine("Введите 3 числа");
int[] numbers = new int[3];
for (int i = 0; i < numbers.Length ; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int max = numbers[0];
for (int i = 0; i<numbers.Length; i++)
{
    if (numbers[i]>max) max = numbers[i];
}
Console.WriteLine("Максимальное число " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Ваше число четное");
}
else
{
    Console.WriteLine("Ваше число нечетное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N;
do
{
    Console.WriteLine("Введите положительное число");
    N = Convert.ToInt32(Console.ReadLine());
} while (N <= 0);

for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}