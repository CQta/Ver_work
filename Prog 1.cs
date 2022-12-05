int[] GetArray(int m) 
{
    int[] result = new int[m];

    for (int i = 0; i < m; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write(inArray[i] + " ");
    }
    Console.WriteLine(" ");
}

void PrintHonNum(int[] inArray)
{
    int kol = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(inArray[i] % 2 ==0)
        {
            kol++;
        }
    }
    Console.Write(kol);
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int rows = int.Parse(Console.ReadLine()!);
int[] array = GetArray(rows);
PrintArray(array);
PrintHonNum(array);