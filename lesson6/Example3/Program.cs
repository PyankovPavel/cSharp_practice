// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void fibona4i(int n) // -> код с семинара
{
    int first = 0;
    int second = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{first} ");
        (first, second) = (second, second + first);
    }
}

fibona4i(7);


// int[] fibona4i(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//         array[i] = i;
//     }

//     for (int i = 2; i < n; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// void printTheArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// printTheArray(fibona4i(7));