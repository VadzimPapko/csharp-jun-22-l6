object[] array = new object[3] { 32, 'A', "Hey" };

foreach (var item in array)
{
    Console.Write(item + " ");
}

Console.WriteLine();

array[0] = 2147483647;
array[2] = "Hey " + "guys!";

foreach (var item in array)
{
    Console.Write(item + " ");
}


