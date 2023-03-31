// // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

// // 4 -> да
// // -3 -> нет
// // 7 -> нет

System.Console.WriteLine("введите число a");
int numberA=Convert.ToInt32(System.Console.ReadLine());
double result=numberA/2.0;
if (Convert.ToInt32(result)==result)
{
System.Console.WriteLine("yes");
}
else
System.Console.WriteLine("no");