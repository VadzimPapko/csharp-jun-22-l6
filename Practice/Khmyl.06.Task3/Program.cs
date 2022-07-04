// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = new int[133];

Random random = new Random();

for (int i = 0; i < arr.Length; i++)
    arr[i] = random.Next(0, 100);

var maxNum = arr.Max();


Console.WriteLine($"Максимальное значение равно {maxNum}");

var index = 0;
foreach(var item in arr)
{
    if (item == maxNum)
        break;
    index++;
}

Console.WriteLine($"Индекс равен {index + 1}.");

foreach (int i in arr)
    Console.Write(i + " ");
