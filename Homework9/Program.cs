// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

void numbersFromNto1(int n, int m)
{
    if(n < m) return;
    numbersFromNto1(n, m+1);
    Console.Write(m + " ");
}
int number = 9;
numbersFromNto1(number, 1);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int sumOfNumbersOfInterval(int m, int n)
{
    if (m == n) return n;
    int sum = sumOfNumbersOfInterval(m+1, n);
    return sum += m;
}

// Console.WriteLine(sumOfNumbersOfInterval(0,8));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunc(int m , int n)
{
    if(m == 0) return n+1;
    else if (m > 0 && n == 0) return AckermannFunc(m-1, 1);
    else return AckermannFunc(m-1, AckermannFunc(m, n-1));
}

// Console.WriteLine(AckermannFunc(3,3));
