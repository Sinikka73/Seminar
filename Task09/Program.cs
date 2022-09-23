// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру в числе

int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int(); // число, которое будет возвращаться
    result = new Random().Next(minBorder, maxBorder + 1); //функция Next возвр.знач. из полуинтервала
    return result;
}
int randomNumber = getRandomNumberFromRange(10, 99);
Console.WriteLine($"Случайное значение {randomNumber}");
//for (int i =0; i < 10; i++)
//{
  //  int randomNumber = getRandomNumberFromRange(10, 99);
    //Console.WriteLine($"{i}. Случайное значение {randomNumber}");
//}