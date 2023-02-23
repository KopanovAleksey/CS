// Console.WriteLine("Введите число");
// string userAnswer = Console.ReadLine();
// int number = Convert.ToInt32(userAnswer); // int number = Convert.ToInt32(Console.ReadLine())
// int result = number * number;
// Console.WriteLine("Квадрат вашего числа равен " + result);

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.WriteLine("Enter two numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 / number2 == number2)
    {
        Console.WriteLine("Число являектся квадратом");
    }
    else
    {
        Console.WriteLine("Число не являектся квадратом");
    }

}
else
{
    if (number2 / number1 == number1)
    {
        Console.WriteLine("Число являектся квадратом");
    }
    else
    {
        Console.WriteLine("Число не являектся квадратом");
    }

}
*/
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
/*
Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Ваш номер превысил ожидания");
}
*/
//Решение со switch
/*
Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Ваш номер превысил ожидания");
        break;
}
*/

//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int i = -number; i <= number; i++)
    {
        Console.Write(i + " ");
    }
}
else
{
    for (int i = -number; i >= number; i--)
    {
        Console.Write(i + " ");
    }
}
*/
//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int n = number%10;
Console.Write(n);
*/