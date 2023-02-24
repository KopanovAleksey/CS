//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

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