//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int temp = n;
do
{
    temp /= 10;
    i++;
} while (temp != 0);
int j = i;
while (i > 0)
{
    temp = temp + n % (int)Math.Pow(10, i) / (int)Math.Pow(10, i - 1) * (int)Math.Pow(10, j - i);
    i--;
}
if (n == temp)
{
    Console.WriteLine("Ваше число палиндром");
}
else
{
    Console.WriteLine("Ваше число не палиндром");
}
*/
