// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool compareNumbers(int a, int b, int c)
{
    if (a + b > c) 
    {
        return true;
    }
    else 
    {
        return false;
    }
}

Console.Write("Первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (compareNumbers(firstNumber, secondNumber, thirdNumber) && 
   (compareNumbers(secondNumber, thirdNumber, firstNumber)) && 
   (compareNumbers(thirdNumber, firstNumber, secondNumber)))
{
    Console.WriteLine($"Треугольник со сторонами {firstNumber} - {secondNumber} - {thirdNumber} может существовать.");
}
else
{
    Console.WriteLine($"Треугольник со сторонами {firstNumber} - {secondNumber} - {thirdNumber} не может существовать.");
}