// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] collection)
{
    
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100,1000);
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
int  eve_num =0;
for (int k = 0; k < array.Length; k++)
{
    if (array[k] % 2 == 0)
    {
        eve_num++;
    }
}

Console.Write($"количество чётных чисел в массиве {eve_num}"); 