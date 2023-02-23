// Console.WriteLine("Введите число");
// string userAnswer = Console.ReadLine();
// int number = Convert.ToInt32(userAnswer); // int number = Convert.ToInt32(Console.ReadLine())
// int result = number * number;
// Console.WriteLine("Квадрат вашего числа равен " + result);

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

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1 )
{
Console.WriteLine("Понедельник");
}
if (number == 2 )
{
Console.WriteLine("Вторник");
}
if (number == 3 )
{
Console.WriteLine("Среда");
}
if (number == 4)
{
Console.WriteLine("Четверг");
}
if (number == 5 )
{
Console.WriteLine("Пятница");
}
if (number == 6 )
{
Console.WriteLine("Суббота");
}
if (number == 7 )
{
Console.WriteLine("Воскресенье");
}
if (number > 7 )
{
Console.WriteLine("Ваш номер превысил ожидания");
}