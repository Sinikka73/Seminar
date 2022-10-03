// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.

Console.Write("Введите положительное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = 1;

for(int i = 1; i <= userNumber; i++)
{
    result = result * 1;
}

Console.WriteLine($"Произведение всех чисел от 1 до {userNumber} равна {result}");