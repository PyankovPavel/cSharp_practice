// Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] fillTheArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
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

int[] proisvOfPairs(int[] array)
{
    int[] new_arr = new int[array.Length / 2 + array.Length % 2];
    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < new_arr.Length; i++)
        {
            new_arr[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    else
    {
        for (int i = 0; i < new_arr.Length; i++)
        {
            new_arr[i] = array[i] * array[array.Length - 1 - i];
        }
        new_arr[new_arr.Length - 1] = array[array.Length/2]; // добавляем последним элементом в новый массив центральный элемент из изначального

    }
    return new_arr;
}

int[] array = fillTheArray(5);
printTheArray(array);
printTheArray(proisvOfPairs(array));
