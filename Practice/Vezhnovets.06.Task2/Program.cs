object [] array = new object [3] {32, 'A', "Hey"};

foreach (var item in array)
{
    Console.Write(item + " ");
}

Console.WriteLine();

int max = int.MaxValue;
array[0] = 32 + max;
array[2] = "Hey" + " guys!";

foreach (var item in array)
{
    Console.Write(item + " ");
}
