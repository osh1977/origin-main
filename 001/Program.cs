//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("введите число a");
int numbera=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("введите число b");
int numberb=Convert.ToInt32(System.Console.ReadLine());
int max=numbera;
if (max>numberb)
{
    System.Console.WriteLine("max =" + max);
}
else 
{
    System.Console.WriteLine("max=" + numberb);
}

//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("введите число a");
int numberA=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("введите число b");
int numberB=Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("введите число c");
int numberc=Convert.ToInt32(System.Console.ReadLine());
int maximum=numberA;
if (numberb>max)
{
  max=numberB;  
}
 if (numberc>max)
 {
    max=numberc;
 }
 System.Console.WriteLine("max =  " + max);


 // // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// // 4 -> да
// // -3 -> нет
// // 7 -> нет

System.Console.WriteLine("введите число a");
int number1A=Convert.ToInt32(System.Console.ReadLine());
double result=number1A/2.0;
if (Convert.ToInt32(result)==result)
{
System.Console.WriteLine("yes");
}
else
System.Console.WriteLine("no");


//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("ввести число N");
int N=Convert.ToInt32(Console.ReadLine());
string resultat = N>=2 ? "" : "облом";
for (int i = 2; i <= N; i=i+2){
    
    resultat+=i+" ";
}
System.Console.WriteLine(resultat);
