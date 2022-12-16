Console.WriteLine("Введите длинну массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимание значение для массива");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для массива");
int max = int.Parse(Console.ReadLine()!);
int[] array = GenArray(size, min, max);
PrintArray(array);
CountArray(array);


int[] GenArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void CountArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }

    }
    Console.WriteLine(count);
}