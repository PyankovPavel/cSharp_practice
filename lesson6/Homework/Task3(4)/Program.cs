// 3: Напишите программу, которая будет создавать копию заданного массива(вещественные числа) с помощью поэлементного копирования.

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

double[] copyTheArray(double[] array)
{
    double[] new_arr = new double[array.Length];
    for (int i = 0; i < new_arr.Length; i++)
    {
        new_arr[i] = array[i];
    }
    return new_arr;
}

double[] array = fillTheArray(5);
printTheArray(array);
printTheArray(copyTheArray(array));