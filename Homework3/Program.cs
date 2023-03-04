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
/*
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
*/
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int n = 0;
do
{
    Console.WriteLine("Введите число больше 0");
    n = Convert.ToInt32(Console.ReadLine());
} while (n < 1);
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}^2 = {Math.Pow(i, 3)}");
}
*/
// Доп. задание
// Написать метод для разворота массива, не используя память под дополнительный массив
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void ReverseArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = { 1, 2, 3, 4, 5, 6 };
PrintArray(array);
ReverseArray(array);
PrintArray(array);