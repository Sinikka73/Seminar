//  Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

void fillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(-5, 5);
        index++;
    }
}

void printArray(int[] col)
{
    Console.Write ("[");
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        if(position < count - 1)
        {
            Console.Write(", ");
        }
        position++;
    }
    Console.Write ("]");
}

int indexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// если решения нет
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }     
        index++;
    }
    return position;
}

int[] array = new int[10];
fillArray(array);
printArray(array);

Console.WriteLine();
Console.Write("Введите число, которое будем искать в массиве: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int pos = indexOf(array, userNumber);

if(pos != (-1))
{
    Console.Write("Искомое число присутствует в массиве");
}
else Console.Write("Искомого числа в массиве нет");
