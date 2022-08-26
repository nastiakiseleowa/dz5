int[] array = { 6, 47, 63, 87, 51 };

int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
}
Console.WriteLine($"Вывести максимальное значение: {max}");

int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = i;
    }
}
Console.WriteLine($"Вывести минимальное значение: {min}");

int result = max - min;
Console.WriteLine($"Вывести результат: {result}");



