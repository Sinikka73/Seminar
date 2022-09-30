// Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А.

void printInConsoleWithColor(string information, ConsoleColor color)//функция изменения цвета 
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();//возвращает изначальный цвет
}

int getSumOfRange(int startPoint, int endPoint)
{
    int result = 0;
    //endPoint = Math.Abs(endPoint); //ф-ция модуля числа
    if(startPoint > endPoint)
    {
        printInConsoleWithColor($"Верхняя граница отрицательна {endPoint}", ConsoleColor.DarkYellow);
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

printInConsoleWithColor("Введите верхнюю границу для суммы ряда",ConsoleColor.DarkMagenta);
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfRange = getSumOfRange(1, userNumber);
Console.WriteLine($"Сумма всех чисел от 1 до {userNumber} равна {sumOfRange}");
