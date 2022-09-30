// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру в числе

int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int(); // число, которое будет возвращаться. инициализация переменной
    result = new Random().Next(minBorder, maxBorder + 1); //функция Next возвр.знач. из полуинтервала
    return result;
}

//for (int i =0; i < 10; i++)
//{
  //  int randomNumber = getRandomNumberFromRange(10, 99);
    //Console.WriteLine($"{i}. Случайное значение {randomNumber}");
//}
int getMaxDigitFromNumber(int number)
{
    int maxDigit = 0;
    while(number >0)
    {
        int currentDigit = number % 10;
        if(maxDigit < currentDigit)
        {
            maxDigit = currentDigit;
        }
        Console.WriteLine(number);
        number = number / 10;
    }
    return maxDigit;
}
int getMaxDigitFromNumberofTwoDigit(int number)
{
    int maxDigit = number % 10;
    int secondDigit = number / 10;
    if(maxDigit < secondDigit)
    {
        maxDigit = secondDigit;
    }

    return maxDigit;
}


int randomNumber = getRandomNumberFromRange(10, 99);
Console.WriteLine($"Случайное значение {randomNumber}");
int maxDigit = getMaxDigitFromNumberofTwoDigit(randomNumber);
Console.WriteLine($"Для числа {randomNumber} большая цифра {maxDigit}");