int[] randomNums = new int[133];
Random random = new Random();

int max = 0;
for (int i = 0; i < randomNums.Length; i++)
{
    randomNums[i] = random.Next(0, 100);
    Console.Write(randomNums[i] + " ");
}

  