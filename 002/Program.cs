//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("введите число a");
int numberA=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("введите число b");
int numberb=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("введите число c");
int numberc=Convert.ToInt32(System.Console.ReadLine());
int max=numberA;
if (numberb>max)
{
  max=numberb;  
}
 if (numberc>max)
 {
    max=numberc;
 }
 System.Console.WriteLine("max =  " + max);