// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

void BeforeMax(int[] array)
{
    int maxVal = 0, currentVal = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (maxVal < array[i])
        {
            currentVal = maxVal;
            maxVal = array[i];
        }
        else if (currentVal < array[i]) currentVal = array[i];
    }
    System.Console.WriteLine($"Максимальное значение: {maxVal}");
    System.Console.WriteLine($"Второе значение по величине: {currentVal}");
}


int length = Prompt("Введите длинну массива: ");

int[] array = CreateArray(length);

PrintArray(array);

BeforeMax(array);
