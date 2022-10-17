// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        System.Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("Введенное число: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine();
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

int num = Prompt("Введите количество цифр в числе: ");

int[] newarray = CreateArray(num);
int sumarray = Sum(newarray);

PrintArray(newarray);
System.Console.WriteLine($"Сумма цифр в введенном числе = {sumarray}");