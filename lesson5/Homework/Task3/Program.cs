// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
// элементов массива. Например, 
// [3, 7, 22, 2, 78] -> 76

double[] fillTheArray(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (100 + 150) - 100, 2);
    }
    return array;
}

void printTheArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

double MaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
        {
            max = array[i];
        }
        else if (array[i] <= min)
        {
            min = array[i];
        }
    }

    return max - min;
}

double[] array = fillTheArray(6);
printTheArray(array);
Console.WriteLine($"Difference beetwen max & min elements: {MaxMinDiff(array)}");