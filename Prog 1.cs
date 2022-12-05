int[] GetArray(int m) 
{
    int[] result = new int[m];

    for (int i = 0; i < m; i++)
    {
        Console.Write("Введите цисло: ");
        result[i] = int.Parse(Console.ReadLine()!);
    }

    return result;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
         Console.Write($"{inArray[i]}\t ");
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int rows = int.Parse(Console.ReadLine()!);
int[] array = GetArray(rows);
PrintArray(array);