// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Например, 
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125.

Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine());

void progression(int number){
    int i = 1;
    while(i<=number){
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}

progression(a);
