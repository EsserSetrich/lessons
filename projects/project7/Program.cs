// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = new Random(). Next(100, 1000);
//Console.WriteLine(num);
int num2 = num/10;
//Console.WriteLine(num2);
int num3 = num2%10;
Console.WriteLine(num3);