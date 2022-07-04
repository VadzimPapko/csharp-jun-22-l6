int[] array = new int[133];

Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 100);
    Console.Write(i + " ");
}
