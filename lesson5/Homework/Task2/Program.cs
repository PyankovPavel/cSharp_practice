// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях. Например,
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

int[] fillTheArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
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

int sumOfOddPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i=i+2)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = fillTheArray(6);
printTheArray(array);
Console.WriteLine($"Sum of elements on odd positions: {sumOfOddPos(array)}");