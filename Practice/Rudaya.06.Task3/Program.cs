int[] myArray = new int[133];

Random random = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(1, 100);
    Console.Write(myArray[i] + " ");
}

Console.WriteLine();

int maxValue = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (maxValue < myArray[i])
    {
        maxValue = myArray[i];
    }
}

int index = Array.IndexOf(myArray, maxValue);
Console.WriteLine(index);

Console.WriteLine($"Max value is {maxValue}, index is {index}.");



