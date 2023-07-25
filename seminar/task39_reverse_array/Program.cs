// create array
// reverse array ==> first becomes last and oposite

int[] array = new int[new Random().Next(5, 50)];

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void ReverseArray()
{
    for (int i = 0; i < array.Length * 0.5; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;

    }
}

Console.WriteLine("");
FillArray();
PrintArray();
Console.WriteLine("");
ReverseArray();
Console.WriteLine("");
PrintArray();
Console.WriteLine("");
