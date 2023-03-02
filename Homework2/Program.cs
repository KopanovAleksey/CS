//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int n = 0;
do
{
    Console.Write("Введите трехзначное число:");
    n = Convert.ToInt32(Console.ReadLine());
} while (!((n < 1000 && n > 99) | (n > -1000 && n < -99)));

Console.WriteLine("Вторая цифра вашего числа = " + n%100/10);
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 == 0)
{
    Console.Write("Третьей цифры нет");
}
else
{
    // int i = 0;
    // int temp = number;
    // do
    // {
    //     temp /= 10 ;
    //     i++;
    // } while (temp != 0);
    // int result = number%(Convert.ToInt32(Math.Pow(10, i-2)))/(Convert.ToInt32(Math.Pow(10, i-3)));
    // Console.WriteLine("Третья цифра вашего числа = " + result);
    //      OR
    while (number >= 1000)
    {
        number /= 10;
    }
    Console.WriteLine("Третья цифра вашего числа = " + number % 10);
}
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
int day = 0;
do
{
    Console.WriteLine("Введите номер дня недели");
    day = Convert.ToInt32(Console.ReadLine());
} while (day<=0 || day > 7);
if (day==7 || day ==6)
{
    Console.WriteLine("Выходной день)");
}else {
    Console.WriteLine("Будний день...(");
}
*/