//Задача 1: Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.

int m = 2;
int n = 12;

void PrintNum(int m, int n)
{
    if (m == n) Console.WriteLine($"{m}");
    else
    {
        Console.Write($"{m}, ");
        PrintNum(m+1, n);
    }
}
PrintNum(m, n);