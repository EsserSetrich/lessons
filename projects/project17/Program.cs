/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/

void FillArray(int[] collection)
{
    
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1,10);
    }
}

void PrintArray(int[] col)
{
    for (int j = 0; j < col.Length; j++)
    {
        Console.Write(col[j] + " ");
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int  sum_odd_number =0;
for (int k = 0; k < array.Length; k++)
{
    if (k % 2 != 0)
    {
        sum_odd_number = sum_odd_number + array[k];
    }
}

Console.WriteLine($"сумма нечетных позицый {sum_odd_number}");