// See https://aka.ms/new-console-template for more information

int[] array = new int[133];

Random random = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(0,100);

foreach (var item in array)
{
    Console.Write(item + ", ");
}

int max = array.Max();
int index = Array.FindLastIndex(array, delegate (int i) { return i == max; });

Console.WriteLine("Индекс: " + index + ", Значение: " + max);