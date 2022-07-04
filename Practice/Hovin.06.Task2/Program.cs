//Task 2

object[] array = new object[] { 32, 'A', "Hey" };
string newString = " guys!";
Console.WriteLine("Our array: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    array[0] = (int)array[0] + Int32.MaxValue;
    array[2] = (string)array[2] + newString;
    break;
}

Console.WriteLine("\nOur new array:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}