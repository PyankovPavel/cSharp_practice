// Задача 3: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123;
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] fillTheArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
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

int countOfElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100)
        {
            count++;
        }
    }
    return count;
}

int[] array = fillTheArray(123);
printTheArray(array);
Console.WriteLine(countOfElements(array));
