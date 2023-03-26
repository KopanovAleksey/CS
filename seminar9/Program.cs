// перевод десятичного в двоичную

void printBinary(int n)
{
    if (n == 0) return;
    printBinary(n/2);
    Console.Write(n%2);
}
// printBinary(13);


// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void printNumbers(int n)
{
    if (n == 0) return;
    printNumbers(n-1);
    Console.Write(n+" ");
}
// printNumbers(6);

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void printNumbersDiapasone(int n, int m)
{
    if (m == n-1) return;
    printNumbersDiapasone(n,m-1);
    Console.Write(m+" ");
}

// printNumbersDiapasone(3,15);

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int SumOfDigits(int number)
{   
    
    if(number == 0) return 0;
    int sum = SumOfDigits(number/10);
    sum += number%10;
    return sum;
}

// Console.WriteLine(SumOfDigits(26366));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

int NumberPow(int number, int pow)
{
    if (pow == 0) return 1;
    int result = NumberPow(number, pow-1);
    result *=number;
    return result;
}

// Console.WriteLine(NumberPow(6,2));

// Дано натуральное число N. Выведите слово YES, если число N является точной степенью двойки, или слово NO в противном случае.
bool ValidatePowTwo(int number)
{
    if (number%2 != 0 && number/2 <= 2) return false;
    if (number/2 == 2 && number%2 == 0) return true;
    
    return ValidatePowTwo(number/2);
}
Console.WriteLine(ValidatePowTwo(14));
