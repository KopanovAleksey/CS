Console.WriteLine("Введите число");
string userAnswer = Console.ReadLine();
int number = Convert.ToInt32(userAnswer); // intnumber = Convert.ToInt32(Console.ReadLine())
int result = number * number;
Console.WriteLine("Квадрат вашего числа равен " + result);