// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine());
if (a > 1){
    int i = 0;
    while (i < a)
    {
        int temp = i + 2;
        if (temp <= a)
        {
            Console.WriteLine(temp);
            i = i + 2;
        }
        else
        {
            return;
        }

    }
}
else
{
    Console.WriteLine("There is no even numbers");
}
