int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

void checking(int a, int b)
{
    if (a % b == 0)
    {
        Console.WriteLine("b кратно a");
    }
    else
    {
        Console.WriteLine("Не кратно, остаток " + a % b);
    }
}

checking(a, b);

