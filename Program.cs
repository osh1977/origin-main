﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("ввести число N");
int N=Convert.ToInt32(Console.ReadLine());
string result = N>2 ? "" : "облом";
for (int i = 2; i <= N; i=i+2){
    
    result+=i+",";
}
System.Console.WriteLine(result);
