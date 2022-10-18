/*  Задача 57: Составить частотный словарь элементов двумерного массива. 
    Частотный словарь содержит информацию о том, сколько раз встречается 
    элемент входных данных.
    Набор данных
    Частотный массив
    { 1, 9, 9, 0, 2, 8, 0, 9 }
    0 встречается 2 раза
    1 встречается 1 раз
    2 встречается 1 раз
    8 встречается 1 раз
    9 встречается 3 раза
    1, 2, 3
    4, 6, 1
    2, 1, 6
    1 встречается 3 раза
    2 встречается 2 раз
    3 встречается 1 раз
    4 встречается 1 раз
    6 встречается 2 раза                                            */

int[,] generateArray(int height, int width, int deviation)
{
    int[,] generatedArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return generatedArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void showArray(int[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] dictNum(int[,] inputArray, int size)
{
    int[] result = new int[size * 2 + 1];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            result[inputArray[i,j] + size]++; 
        }
    }
    return result;
}

void printDictNum(int[] dictNum)
{
    int size = (dictNum.Length - 1) / 2;
    for (int i = 0; i < dictNum.Length; i++)
    {
        if (dictNum[i] != 0)
        {
            Console.WriteLine($"Элемент {i - size} встречается {dictNum[i]} раз");
        }
    }
}

int size = 10;
int[,] generatedArray = generateArray(5, 5, size);
showArray(generatedArray);

int[] dictNumber = dictNum(generatedArray, size);
printDictNum(dictNumber);
