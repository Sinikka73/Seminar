// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

string getCoordinateRangeFromQuarter(int quarterNumber)
{
    string result = "";
    if(quarterNumber == 1)
    {
        Console.Write($"Для {quarterNumber} четверти координаты ");
        result = "X > 0, Y > 0";
    }
    else if(quarterNumber == 2)
    {
        Console.Write($"Для {quarterNumber} четверти координаты ");
        result = "X > 0, Y < 0";
    }
    else if(quarterNumber == 3)
    {
        Console.Write($"Для {quarterNumber} четверти координаты ");
        result = "X < 0, Y < 0";
    }
    else if(quarterNumber == 4)
    {
        Console.Write($"Для {quarterNumber} четверти координаты ");
        result = "X < 0, Y > 0";
    }
    else result = "Ошибка ввода. Введите целое число от 1 до 4.";
    return result;
}
    

Console.WriteLine("Введите целое число от 1 до 4");
int quarterNumber = Convert.ToInt32(Console.ReadLine());
Console.Write(getCoordinateRangeFromQuarter(quarterNumber));