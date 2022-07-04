int[] arr = new int[133];
Random random= new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(0,100);
    Console.Write(arr[i]);
}
Console.WriteLine();
int max = arr.Max();
int index = Array.IndexOf(arr, max);
Console.WriteLine($"Max number:{max}");
Console.WriteLine($"Index : {index}");





