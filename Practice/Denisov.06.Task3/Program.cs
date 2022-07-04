int[] randNum = new int[133];
Random rand = new Random();

for (int i = 0; i < randNum.Length; i++)
{
    randNum[i] = rand.Next(0,100);
}
foreach (int i in randNum)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n");
int maxValue = randNum.Max();
Console.WriteLine($"Max value is: {maxValue}");