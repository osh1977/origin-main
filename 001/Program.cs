//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("введите число a");
int numberA=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("введите число b");
int numberb=Convert.ToInt32(System.Console.ReadLine());
int max=numberA;
if (max>numberb)
{
    System.Console.WriteLine("max =" + max);
}
else 
{
    System.Console.WriteLine("max=numberb");
} 
