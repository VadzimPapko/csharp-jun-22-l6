// See https://aka.ms/new-console-template for more information

// Max Element in Array

int[] arrayRandom = new int[133];
Random numberRandom = new Random();

for (int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = numberRandom.Next(0, 100);
    Console.Write(arrayRandom[i] + "\t");
}
int maxValue = arrayRandom.Max();
int indexMax = Array.IndexOf(arrayRandom, maxValue);

Console.WriteLine();
Console.WriteLine("\nМаксимальный элемент в массиве равен " + maxValue + ", его индекс " + indexMax);