// convert decimal to binary

Console.WriteLine("Please Input number");
int num = Convert.ToInt32(Console.ReadLine());

string result = String.Empty;

while (num > 0)
{
    result = Convert.ToString(num % 2) + result;
    num /= 2;
}

Console.WriteLine($"decimal number {num} corresponds to following binary: {result}");

// int[] array = new int[100];
// int count = 8;

// void Fill9()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 9;
//     }
// }

// void Conversion()
// {
//     for (int i = 0; num % 2 > 1; i++)
//     {
//         num = num / 2;
//         if (num % 2 == 0)
//         {
//             array[i] = 0;
//         }
//         else
//         {
//             array[i] = 1;
//         }
//     }
// }

// void Print()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
// }

// void CountDigits()
// {
//     for (int i = 0; array[i] != 0 && array[i] != 1; i++)
//     {
//         count = count + 1;
//     }
//     Console.WriteLine($"count: {count}");
// }

// int[] binary = new int[count];

// void FillBinary()
// {
//     for (int i = 0; i < binary.Length; i++)
//     {
//         binary[i] = 9;
//     }
// }

// void Cut()
// {
//     for (int i = 0; i < binary.Length; i++)
//     {
//         binary[i] = array[i];
//     }
// }

// void PrintBinary()
// {
//     for (int i = 0; i < binary.Length; i++)
//     {
//         Console.Write(binary[i]);
//     }
// }

// Fill9();
// // Print();
// Conversion();
// Console.WriteLine("");
// Print();
// Console.WriteLine("");
// CountDigits();
// FillBinary();
// Cut();
// Console.WriteLine("");
// PrintBinary();
// Console.WriteLine("");
