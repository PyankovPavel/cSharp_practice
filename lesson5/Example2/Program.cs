// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Например:
// 4; массив [6, 7, 19, 345, 3] -> нет, 
// 3; массив [6, 7, 19, 345, 3] -> да

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

void findTheNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num){
            Console.WriteLine("Yes");
            break;
        }
    }
    Console.WriteLine("No");
}

Console.Write("Enter the number to find ");
int find = int.Parse(Console.ReadLine());
int[] array = fillTheArray(5);
printTheArray(array);
findTheNum(array, find);

