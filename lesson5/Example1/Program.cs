// Задача 1: Напишите программу замена элементов массива: положительные элементы замените на соответствующие
// отрицательные, и наоборот. Например,
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

void changePostoNeg(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     array[i] *= -1;
    }
    printTheArray(array);
}

int[] array = fillTheArray(4);
printTheArray(array);
changePostoNeg(array);