void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;

    while (index < Length)
    {
        collection[index] = new Random().Next(100, 999);
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
int n = array.Length;

FillArray(array);
PrintArray(array);


int quantity = 0;
for (int i = 0; i < array.Length; i++)
{
if (array [i] % 2 == 0)
{
    quantity++;
}
}
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
