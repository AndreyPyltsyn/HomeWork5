Console.WriteLine("Введите длинну массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимание значение для массива");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для массива");
int max = int.Parse(Console.ReadLine()!);
double[] array = GenArray(size, min, max);
PrintArray(array);
MaxNumber(array);
MinNumber(array);
Console.WriteLine(MaxNumber(array) - MinNumber(array));



double[] GenArray(int n, int min, int max)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MaxNumber(double[] array)
{
    double max = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }

    }
    return max;
}
double MinNumber(double[] array)
{
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }

    }
    return min;
}
