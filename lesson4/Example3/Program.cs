// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void MakingArray(int n)
{
    int[] array = new int[n];
    Console.Write("[");
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

MakingArray(8);
