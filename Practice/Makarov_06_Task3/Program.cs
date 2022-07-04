int[] array = new int[133];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 100);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}
int max = array.Max();
int maxindx = Array.IndexOf(array, array.Max());
Console.WriteLine(" Max element = " + max + " Index: " + maxindx);