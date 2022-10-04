// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for(int i =0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}

void printArray(int[] incomingArray)
{
    Console.Write ("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if(i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int countElemensInArray(int[] incomingArray)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i] > 9 && incomingArray[i] < 100)
        {
            count = count +1;
        }

    }
    return count;
}

Console.WriteLine();
int[] currentArray = getRandomArray(123, 1, 200);
printArray(currentArray);
Console.WriteLine();
int count = countElemensInArray(currentArray);
Console.WriteLine($"В текущем массиве элементов по условию задачи: {count}");
Console.WriteLine();