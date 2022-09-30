//  Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 1)
    //Метод int.TryParse(string s, out int result) 
    //проверяет, можно ли получить число из строки. Если это возможно - 
    //возвращает true и полученное число out-параметром, иначе возвращает 
    //false результатом и default(int) out-параметром.
    // ! - не равно. т.е. пока TryParse НЕ может получить целое число
    {
        Console.Write($"Ошибка ввода! Ожидается целое число больше единицы. {userInformation} ");
    }
    return result;
}
//                              userInformation
int number = getNumberFromUser("Введите целое число N > 1: ");
//Присваивает результат result из функции getNumberFromUser

int[] tableQuarterNumber(int number)
{
    int[] result = new int [number];
    for(int i = 1; i <= number; i++)
    {
        result[i - 1] = (int)(Math.Pow(i, 2));
    }
    return result;
}

int[] table = tableQuarterNumber(number);


for (int i = 0; i < table.Length; i++)
{
    Console.Write(table[i] + " ");
} 

/*foreach (var value in table)
{
    Console.Write(value + " ");
} */