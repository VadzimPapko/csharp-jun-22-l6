Random random = new();
int maxElements = 100;
int elementCount = 133;

Console.WriteLine("\nRandom array:");

int[] myArray = new int[elementCount];

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(maxElements);
    Console.Write(myArray[i] + " | ");
}

int maxElement = myArray.Max();
int indexMin = Array.IndexOf(myArray, maxElement);

Console.WriteLine();
Console.WriteLine("Max element");
Console.WriteLine(maxElement);

Console.WriteLine("Index");
Console.WriteLine(indexMin);