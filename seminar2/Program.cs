/*
int a = Random.Shared.Next(10,100);
int unit = a%10;
int ten = a/10;
Console.WriteLine(a);
Console.WriteLine(unit);
Console.WriteLine(ten);
if (unit > ten)
{
    Console.WriteLine("Нaибольшая цифра числа - " + unit);
} else if (unit < ten)
{
    Console.WriteLine("Нaибольшая цифра числа - " + ten);
} else
{
    Console.WriteLine("Цифры числа равны = " + ten);
}
*/
/*
int number = Random.Shared.Next(100,1000);
int first = number/100;
int third = number%10;
int result = first*10+third;
Console.WriteLine("Изначальное число - " + number);
Console.WriteLine("Число без 2ой цифры - " + result);
*/
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

/*
Console.WriteLine("Введите 2 числа на проверку кратности.");
Console.Write("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 0;
do
{
    Console.Write("Введите 2 число: ");
    number2 = Convert.ToInt32(Console.ReadLine());
} while (number2 == 0);

if (number1 % number2 == 0)
{
    Console.WriteLine("Число " + number1 + " кратно " + number2);
}
else
{
    Console.WriteLine("Число " + number1 + " не кратно " + number2 + ". И остаток от деления = " + number1 % number2);
}
*/

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Ваше число кратно 7 и 23");
}
else if (number % 7 == 0)
{
    Console.WriteLine("Ваше число кратно только 7");
}
else if (number % 23 == 0)
{
    Console.WriteLine("Ваше число кратно только 23");
}
else
{
    Console.WriteLine("Ваше число не кратно 7 и 23");
}
*/

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
Console.WriteLine("Введите 2 числа:");
Console.Write("Введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 * num1 == num2)
{
    Console.WriteLine("Число " + num2 + " является квадратом числа " + num1);
}
else if (num2 * num2 == num1)
{
    Console.WriteLine("Число " + num1 + " является квадратом числа " + num2);
}
else
{
    Console.WriteLine("Числа не имеют квадратичных взаимосвязей");
}
*/