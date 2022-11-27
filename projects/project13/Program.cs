// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int num = ReadInt("Введите первое число: ");
int num2 = ReadInt("Введите второе число: ");

    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num;
    }
    Console.WriteLine(result);

// // Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}