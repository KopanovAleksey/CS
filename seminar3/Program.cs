//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
Console.Write("Введите кординату x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату y = ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0){
    Console.Write("Точка в 1ой четверти");
}else if (x<0 && y>0){
    Console.Write("Точка во 2ой четверти");
} else if (x<0 && y<0){
    Console.Write("Точка в 3ей четверти");
} else if (x>0 && y<0){
    Console.Write("Точка в 4ой четверти");
} else {
    Console.Write("Невозможно определить четверть");
}
*/

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
int n = 0;
do
{
    Console.Write("Введите номер координатной четверти ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0 || n > 4) Console.WriteLine("Вы ввели несуществующую четверть");
} while (n <= 0 || n > 4);
if (n == 1)
{
    Console.Write("x>0 && y>0");
}
else if (n == 2)
{
    Console.Write("x<0 && y>0");
}
else if (n == 3)
{
    Console.Write("x<0 && y<0");
}
else
{
    Console.Write("x>0 && y<0");
}
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
Console.WriteLine("Введите координаты 2ух точек");
Console.WriteLine("Введите координату X 1 точки");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y 1 точки");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X 2 точки");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y 2 точки");
double y2 = Convert.ToDouble(Console.ReadLine());

double lenght = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 1);
Console.WriteLine("Длина отрезка равна = " + lenght);
*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int n = 0;
do
{
    Console.WriteLine("Введите число больше 0");
    n = Convert.ToInt32(Console.ReadLine());
} while (n < 1);
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
}
