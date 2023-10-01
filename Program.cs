using System;

Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите k:");
int k = int.Parse(Console.ReadLine());

Console.WriteLine("Введите l:");
int l = int.Parse(Console.ReadLine());
Console.WriteLine(((n + m) > k) ^ (n > k && m < l));