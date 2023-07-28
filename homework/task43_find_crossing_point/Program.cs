// find crossing point of two lines given by following equations:
// y = k1 * x + b1
// y = k2 * x + b2
// b1, k1, b2, k2 - user input
Console.WriteLine("please input b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"x= {x}");
Console.WriteLine($"y= {y}");