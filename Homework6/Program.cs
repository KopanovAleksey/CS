// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] ArrayOfUser()
{
    Console.Write($"Сколько чисел вы хотите внести ? ");
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int countOfPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
void main1()
{
    int[] arr = ArrayOfUser();
    int n = countOfPositive(arr);
    Console.WriteLine($"Ваш массив:{String.Join(" ", arr)}, а количество цифр больше 0 : {n}.");
}

//main1();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] lineDef(int n)
{
    Console.WriteLine($"Введите параметры {n} линейного уравнения типа: y = k{n}*x + b{n}");
    double[] lineParameters = new double[2];
    Console.Write($"Введите параметр k{n} = ");
    lineParameters[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите параметр b{n} = ");
    lineParameters[1] = Convert.ToDouble(Console.ReadLine());
    return lineParameters;
}
bool validLineData(double[] line1, double[] line2)
{
    if (line1[0] == line2[0])
    {
        if (line1[1] == line2[1])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые паралельны");
            return false;
        }
    }
    return true;
}
void lineCrossSection(double[] line1, double[] line2)
{
    double[] dot = new double[2];
    if (validLineData(line1, line2))
    {
        dot[0] = (line2[1] - line1[1]) / (line1[0] - line2[0]);
        dot[1] = dot[0] * line1[0] + line1[1];
        Console.WriteLine($"Точкаа пересечения прямых y = {line1[0]}*x + {line1[1]} и y = {line2[0]}*x + {line2[1]} : [{dot[0]};{dot[1]}].");
    }
}
void main2()
{
    double[] l1 = lineDef(1);
    double[] l2 = lineDef(2);
    lineCrossSection(l1, l2);
}

main2();