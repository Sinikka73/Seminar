
/*  Задача 51: Задайте двумерный массив. Найдите элементы, у которых 
    оба индекса чётные, и замените эти элементы на их квадраты.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Сумма элементов главной диагонали: 1 + 9 + 2 = 12                 */


int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] findOddArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i,j] *=  array[i,j];
        }
    }
    return array;
}

// void printSumMainDiagonal(int[,] array)
// {
//     Console.Write("Сумма элементов главной диагонали: ");
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if ( i == j)
//             {
//                 Console.Write(array[i,j]);
//                 if (i < array.GetLength(0) - 1)
//                 {
//                     Console.Write(" + ");
//                 }
//                 sum += array[i,j];
//             }
//         }
//     }
//     Console.Write(" = " + sum);
// }

void printSumMainDiagonal(int[,] array)
{
    Console.Write("Сумма элементов главной диагонали: ");
    int sum = 0;
    if (array.GetLength(0) < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,i];
            Console.Write(array[i,i]);
            if (i < array.GetLength(0) - 1)
            {
                    Console.Write(" + ");
            }
        }
    }
    Console.Write(" = " + sum);
}

int[,] generateArray = generate2DArray(3,4,1,9);
int[,] oddArray = findOddArray(generateArray);
print2DArray(oddArray);
printSumMainDiagonal(oddArray);
