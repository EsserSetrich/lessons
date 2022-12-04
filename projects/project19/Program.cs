/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
void FillConsPrintArray(double[] collection)
{
    
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write("Введите число: ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}
double[] array = new double[5];

FillConsPrintArray(array);
Console.WriteLine();

int  num =0;
for (int k = 0; k < array.Length; k++)
{
    if (array[k] > 0)
    {
        num++;
    }
}
Console.Write($"{num} чисел больше 0 ввёл пользователь.");