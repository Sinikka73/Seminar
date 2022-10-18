/*  Задача 63: Задайте значение N. Напишите программу, которая выведет 
    все натуральные числа в промежутке от 1 до N.
    N = 5 -> "1, 2, 3, 4, 5"
    N = 6 -> "1, 2, 3, 4, 5, 6"                                     */

Console.Write("Введите число N: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
printRange(userNumber);

void printRange(int N)
{
    if (N == 0)
    {
        return;
    }
    printRange(N - 1);
    Console.Write($"{N}, ");
}
/* 
void printRange(int N)
{
    if (N != 0)
    {
        printRange(N - 1);
        Console.Write($"{N}, ");
    }
}
*/