﻿// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int a = new int();
Console.WriteLine("Введите первое число");
a = Convert.ToInt32(Console.ReadLine());
int max = a;
int b = new int();
Console.WriteLine("Введите второе число");
b = Convert.ToInt32(Console.ReadLine());
int c = new int();
Console.WriteLine("Введите третье число");
c = Convert.ToInt32(Console.ReadLine());
if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
Console.Write("max = ");
Console.WriteLine(max);