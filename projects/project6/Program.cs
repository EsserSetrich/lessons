// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

 Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while( count < (num + 1))
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count += 1;
}