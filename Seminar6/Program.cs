int[] getRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}
int[] DecimalToBinary(int number)
{
    int temp = number;
    int i = 0;
    while(temp >0)
    {
        temp/=2;
        i++;
    }
    int[] array = new int[i];
    for (int j = 0; j<array.Length; j++)
    {
        array[array.Length-1-j] = number%2;
        number /=2;
    }
    return array;
}
int DecToBin(int number)
{
    int binary = 0;
    for(int i= 0; number > 0; i++)
    {
        binary+= (number%2)*Convert.ToInt32(Math.Pow(10, i));
        number/=2;
    }
    return binary;
}

int[] Fibonachi(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i< number; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

void TriangleExistance(int a, int b, int c)
{
    if(a+b>c && a+c>b && b+c>a) 
    {
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} Существует");
    } 
    else
    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} Не существует");
}

int[] copyArray(int[] array)
{
    int [] arr = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}
void Main()
{
    // int[] myArray = getRandomArray(10, 0, 20);
    // PrintArray(myArray);
    // ReverseArray(myArray);
    // PrintArray(myArray);

    // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
    // Console.WriteLine(DecToBin(356));
    // PrintArray(DecimalToBinary(356));
    
    // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
    // PrintArray(Fibonachi(10));

    // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
    // может ли существовать треугольник с сторонами такой длины.
    // Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
    // TriangleExistance(1, 2, 20);

    // Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
    int[] array1 = getRandomArray(10, 0, 100);
    int[] array2 = copyArray(array1);
    PrintArray(array1);
    PrintArray(array2);

}

Main();


