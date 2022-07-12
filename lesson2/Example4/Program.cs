int a = int.Parse(Console.ReadLine());
void checking(int a)
{
    if (a % 7 == 0 && a % 23 == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
checking(a);
