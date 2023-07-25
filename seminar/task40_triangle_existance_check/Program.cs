// check if triangle with length input exists

Console.WriteLine("Please Input length of Side A");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Input length of Side B");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Input length of Side C");
int sideC = Convert.ToInt32(Console.ReadLine());

if (sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB) 
{
    Console.WriteLine("triangle exists");
}

else Console.WriteLine("triangle doesn't exist");