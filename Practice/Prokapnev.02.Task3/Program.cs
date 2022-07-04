int[]array=new int[133];

for (int i=0; i<array.Length;i++) array[i]=new Random().Next(0,100);

for (int i = 0; i<array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine();

int valueMax = array[0];
int indexMax = 0;

for (int i = 1; i<array.Length; i++)
{
    if (array[i]>valueMax)
    {
        indexMax = i;
        valueMax=array[i];
    }
}

Console.WriteLine($"Maximum array element is {valueMax}");
Console.WriteLine($"The index of maximum array element is {indexMax}");