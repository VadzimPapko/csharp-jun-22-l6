uint length = 133;
int minValue = 0;
int maxValue = 100;

int[] myArray = new int[length];

Random random = new Random();

Console.WriteLine("массив: ");

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(minValue, maxValue);

    Console.Write($"{myArray[i]} ");
}

int desiredMaxValue = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > desiredMaxValue)
    {
        desiredMaxValue = myArray[i];
    }
}

Console.WriteLine($"\n\nмаксимальное значение в нашем массиве: {desiredMaxValue}");