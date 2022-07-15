// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Enter a number ");
int a = int.Parse(Console.ReadLine());

void progress(int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.WriteLine(Math.Pow(i, 2));
        i++;
    }
}

progress(5);