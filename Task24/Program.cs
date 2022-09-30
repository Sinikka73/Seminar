// Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А.

int getSumOfRange(int startPoint, int endPoint)
{
    int result = 0;
    //endPoint = Math.Abs(endPoint); //ф-ция модуля числа
    if(startPoint > endPoint)
    {
        //Console.ForegraundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Верхняя граница отрицательная {endPoint}");
        //Console.ResetColor();
        int buff = startPoint;
        startPoint = endPoint;
        endPoint = buff;
    }
    for(int i = startPoint; i <= endPoint; i++)
    {
        result += i;//result = result + i
    }
    return result;
}

Console.WriteLine("Введите верхнюю границу для суммы ряда");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfRange = getSumOfRange(1, userNumber);
Console.WriteLine($"Сумма всех чисел от 1 до {userNumber} равна {sumOfRange}");
