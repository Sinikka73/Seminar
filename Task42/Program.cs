// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

int convertToString(int number)
{
    int count = 1;
    int remains = number % 2;
    int temp = number / 2;
    int result = remains;
    while (temp != 0)
    {
        remains = temp % 2;
        temp = temp / 2;
        count = count * 10;
        result += remains * count;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int bite = convertToString(number);
Console.Write(bite);

/*Console.Clear();
Console.WriteLine("Программа по преобразованию десятичного числа в двоичное");
string userChoice = "y";
while(userChoice.ToLower == "y")
{
    Console.WriteLine("Вы хотите продолжить? Да - y. Нет - n");
    userChoice = Console.ReadLine();
    while(userChoice.ToLower != "y" && userChoice.ToLower != "n")
    {
        Console.WriteLine("Введите правильное значение: Да - y. Нет - n");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("До встречи!");*/