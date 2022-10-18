// Составить новый массив из произведений пар с двух концов элементов
// заданного массива


int[] generateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void printArray(int[] arrayToPrint, string name)
{
    Console.WriteLine($"---------------{name} --------------");
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if(i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

int[] sumOfBordersElemetsOfArray(int[] inputArray)
{
    int lengthOfNewArray = (int)Math.Ceiling(inputArray.Length / 2.0);//функция округления вверх
    Console.WriteLine($"Для количества {inputArray.Length} новый массив {lengthOfNewArray}");
    int[] result = new int[lengthOfNewArray];
    for (int i = 0; i < lengthOfNewArray; i++)
    {
        if(i != inputArray.Length - i - 1)
        {
        result[i] = inputArray[i]*inputArray[inputArray.Length - i - 1];
        }
        else
        {
            result[i] = inputArray[i];
        }
    }
    return result;
}

Console.WriteLine();
int[] curentArray = generateArray(9, 1, 10);
printArray(curentArray, "Исходный");
int[] sumOfBorders = sumOfBordersElemetsOfArray(curentArray);
printArray(sumOfBorders, "Новый");