// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру в числе

int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int(); // число, которое будет возвращаться
    result = newRandom().Next(minBorder, maxBorder + 1); //функция Next возвр.знач. из полуинтервала
    return result;
}

