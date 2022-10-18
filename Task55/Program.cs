/*  Задача 55: Задайте двумерный массив. Напишите программу, 
    которая заменяет строки на столбцы. В случае, если это невозможно, 
    программа должна вывести сообщение для пользователя.            */

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

int[,] turnMatrix(int[,] inputArray)
{
    if (inputArray.GetLength(0) == inputArray.GetLength(1))
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = i + 1; j < inputArray.GetLength(1); j++)
            {
                int buffer = inputArray[j, i];
                inputArray[j, i] = inputArray[i, j];
                inputArray[i, j] = buffer;
            }
        }
    }
    else Console.WriteLine("Матрицу невозможно перевернуть.");
    return inputArray;
}


int[,] generatedArray = generateArray(5, 5, 100);
showArray(generatedArray);
int[,] swopedArray = turnMatrix(generatedArray);
showArray(swopedArray);