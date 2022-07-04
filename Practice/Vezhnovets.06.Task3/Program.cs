int[] array = new int[133];

Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 100);
}

foreach (int i in array)
{
    Console.Write(i + " ");
}

Console.WriteLine();

int max  = array[0];
int index = 0;

for (int i = 0; i < array.Length; i++)
{
    if( max < array[i])
    {
        max = array[i];
        index = i;
    }
}
Console.WriteLine($"Максимальный элемент равен: {max}, индекс {index}");