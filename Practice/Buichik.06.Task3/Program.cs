int[] mas = new int[133];

Random random = new Random(100);
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(0, 100);
    Console.Write("{0}", mas[i]);
}
int max = mas.Max();
Console.WriteLine("\nМаксимальное число {0}", max);
