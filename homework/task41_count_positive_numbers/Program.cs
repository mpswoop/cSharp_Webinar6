// user input positive and negative numbers
// count how many numbers are > 0


double[] numbers = new double[new Random().Next(4, 11)];
Console.WriteLine(numbers.Length);

void Numbers()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"please input number # {i+1}");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(i);
    }

}

void Print()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
}

void CountPositive()
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"number of positives: {count}");
    Console.WriteLine();
}

Numbers();

Print();

CountPositive();