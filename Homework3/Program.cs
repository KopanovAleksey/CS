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
//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты 2ух точек в 3D пространстве ");
Console.WriteLine("Введите координату x1 точки");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1 точки");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z1 точки");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x2 точки");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2 точки");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z2 точки");
double z2 = Convert.ToDouble(Console.ReadLine());

double lenght = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+Math.Pow(z1 - z2, 2)), 1);
Console.WriteLine("Длина отрезка равна = " + lenght);
