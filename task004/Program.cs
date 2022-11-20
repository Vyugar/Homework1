// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int a = 0;
int n = new int();
Console.WriteLine("Введите число ");
n = Convert.ToInt32(Console.ReadLine());
while (a < n - 1)
        {
        a += 2;
        Console.WriteLine(a);
    }
Console.Write("Приведены все четные числа от 1 до введенного Вами числа");
  