// See https://aka.ms/new-console-template for more information

int[] arr = new int[133];
Random rnd = new Random();

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 100);
    Console.Write(arr[i]);
}
int maxValue = arr.Max<int>();
Console.Write(" Максимальное число " + maxValue);

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= maxValue)
    {
        maxValue = arr[i];
        int index = i;
        Console.Write(" Индекс " + index);
    }
}