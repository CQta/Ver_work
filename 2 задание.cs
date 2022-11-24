System.Console.WriteLine("Введите кеш");
double N = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите годовой процент");
double M = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите цена квартиры");
double K = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите годовой процент квартиры");
double Q = double.Parse(Console.ReadLine());
int i = 0;
if (Q < M)
{
    while (N < K)
    {
        N = N + (N / (double)100 * M);
        K = K + (K / (double)100 * Q);
        i++;
    }
    Console.WriteLine("Жди " + i + " лет");
}
else
{
    Console.WriteLine("Квартиру не получешь");
}

