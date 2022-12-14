/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int len = 4;
int[,] array = new int[len, len];
FillArraySpiral(array, len);
PrintArray(array);

void FillArraySpiral(int[,] collection, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { collection[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) collection[i++, j] = value++;
        for (k = 0; k < n - 1; k++) collection[i, j--] = value++;
        for (k = 0; k < n - 1; k++) collection[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            if (collection[i, j] < 10)
            {
                Console.Write("0" + collection[i, j]);
                Console.Write(" ");
            }
            else Console.Write(collection[i, j] + " ");
        }
        Console.WriteLine();
    }
}