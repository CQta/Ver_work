string[] GetArray(int m) 
{
    string[] result = new string[m];

    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите элемент массива");
        result[i] = Console.ReadLine()!;
    }
    return result;
}

void PrintFullArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]}\t ");
    }
    Console.WriteLine("");
    Console.WriteLine("");
}

void PrintEndArray(string[] inArray)
{  
    
    int buf = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(inArray[i].Length <= 3) buf++;
    }
    string[] EndArray = new string[buf];
    buf = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(inArray[i].Length <= 3)
        {
            EndArray[buf] = inArray[i];
            buf++;
            Console.Write($"{inArray[i]}\t ");
        }
    }
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int kol = int.Parse(Console.ReadLine()!);
string[] array = GetArray(kol);
PrintFullArray(array);
PrintEndArray(array);