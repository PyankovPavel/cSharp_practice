// Задача 1: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.). Например:
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] turnArray(int[] array)
{
    // int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        // temp = array[i];
        // array[i] = array[array.Length - i - 1]; // -> тоже рабочий код
        // array[array.Length - i - 1] = temp;

        (array[i], array[array.Length - i - 1]) = (array[array.Length - i - 1], array[i]); // -> метод "кортежей" с семинара
    }

    return array;
}

int[] array = fillTheArray(4);
printTheArray(array);
printTheArray(turnArray(array));
