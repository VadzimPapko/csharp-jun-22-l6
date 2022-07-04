//Borovik.06.Task2

object[] arr = new object[] {32, 'A', "Hey"};
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

for (int i = 0; i < arr.Length; i++)
{
    arr[0] =+ int.MaxValue;
    string s = " guys!";
    arr[2] = "Hey " + " guys!";
    Console.Write(arr[i] + " ");
}

