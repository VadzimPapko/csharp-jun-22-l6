// Task 3

Random random = new Random();
int[] array = new int[133];
int maxValue = default;
int indexOfMax = default;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 100);
    Console.Write(array[i] + " ");
}

maxValue = array.Max();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == array.Max())
    {
        indexOfMax = i;
        break;
    }
}

Console.WriteLine("\nMax value = "+ maxValue + " with index = " + indexOfMax);