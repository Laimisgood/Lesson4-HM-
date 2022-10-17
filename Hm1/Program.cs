// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = Prompt("Введите число: ");
int num2 = Prompt("Введите степнь: ");

int Pow(int value1, int value2)
{   
    int pow = 1;
    for (int i = 0; i < value2; i++)
    {
        pow *= value1;
    }
    return pow;
}

System.Console.WriteLine(Pow(num1, num2));
