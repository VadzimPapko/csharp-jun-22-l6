// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = new int[133];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 100);
    Console.Write(arr[i] + " ");
}

int maxElem = 0;
int maxInd = 0;

for (int i = 0; i < arr.Length; i++)
if (arr[i] > maxElem) 
    { 
        maxElem = arr[i];
        maxInd = i;
    }

Console.WriteLine();
Console.WriteLine("Максимальный элкмент массива равен " + maxElem + " индекс этого элемента равен " + maxInd);