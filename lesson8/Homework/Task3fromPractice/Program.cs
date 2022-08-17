// Задача 3: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9, например:
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[,] fillArray()
{
    Console.Write("Enter number of rows: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Enter number of columns: ");
    int n = int.Parse(Console.ReadLine());
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void countOfElements(int[,] array)
{
    int checkNumber = 0;
    int count = 0;
    while (checkNumber < 10)
    {
        foreach (int number in array)
        {
            if (number == checkNumber)
            {
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"{checkNumber} appears {count} times");
        }
        checkNumber++;
        count = 0;
    }
}

int[,] array = fillArray();
printArray(array);
Console.WriteLine();
countOfElements(array);
