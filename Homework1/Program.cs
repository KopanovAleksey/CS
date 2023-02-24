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
