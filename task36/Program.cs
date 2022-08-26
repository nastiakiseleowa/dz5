void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 100);
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

int[] array = new int[4];

FillArray(array);
PrintArray(array);

int n = array.Length;
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum = sum += array[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
