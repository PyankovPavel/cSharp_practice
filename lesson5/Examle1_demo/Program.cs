// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] fillTheArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void printTheArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");

}

void SumMinMax(int[] array)
{
    int pos = 0;
    int neg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            pos += array[i];
        }
        else
        {
            neg += array[i];
        }
    }
    Console.WriteLine($"Sum of pos =  {pos} , sum of negs =  {neg}");
}

printTheArray(fillTheArray(12));
SumMinMax(fillTheArray(12));

