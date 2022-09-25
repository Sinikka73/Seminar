//  Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка. 

int getQuarterFromCoordinate(int coordinateX, int coordinateY)
{
    int result = 0;
    if(coordinateX > 0 && coordinateY > 0)
    {
        result = 1;
    }
    else if(coordinateX < 0 && coordinateY > 0)
    {
        result = 2;
    }
    else if(coordinateX < 0 && coordinateY < 0)
    {
        result = 3;
    }
    else if(coordinateX > 0 && coordinateY < 0)
    {
        result = 4;
    }
    return result;
}

int getCoordinateFromUser()
{
    int result = 0;
    while(result == 0)
    {
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if(result == 0)
        {
           Console.WriteLine($"Введите целое число. Вы ввели {userLine}");
        }
    }
    return result;
}
int userCoordinateX = 0;
int userCoordinateY = 0;
Console.WriteLine("Введите координаты");
Console.Write ("Х: ");
userCoordinateX = getCoordinateFromUser();
Console.Write ("Y: ");
userCoordinateY = getCoordinateFromUser();

int quarter = getQuarterFromCoordinate(userCoordinateX, userCoordinateY);
if(quarter > 0)
{
   Console.WriteLine($"Точка с координатами [{userCoordinateX}:{userCoordinateY}] находится в четверти {quarter}");
}
else
{
    Console.WriteLine($"Одна из координат является нулевой. Определить четверть, в которой находится точка, не представляется возможным [{userCoordinateX}:{userCoordinateY}]");
}