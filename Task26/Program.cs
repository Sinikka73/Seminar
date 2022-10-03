// Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе.


Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
userNumber = Math.Abs(userNumber);
int result = 1;
if(userNumber !=0)
{
    result = (int)Math.Log10(userNumber) + 1;
}
Console.WriteLine($"Количество знаков в числе {result}");