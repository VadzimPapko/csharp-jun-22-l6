//Borovik.06.Task2

object[] arr = new object[] {32, 'A', "Hey"};
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine(" ");
for (int i = 0; i < arr.Length; i++)
{
    arr[0] =+ int.MaxValue;
    arr[2] = "Hey" + " guys!";
    Console.Write(arr[i] + " ");
}

