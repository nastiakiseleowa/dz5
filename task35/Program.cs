void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;

    while (index < Length)
    {
        collection[index] = new Random().Next(0, 123);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[123];
int n = array.Length;

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i > 9 && i < 100)
    count++;
}

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10;99]: {count}");
