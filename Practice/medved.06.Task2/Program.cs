
object[] myArray = new object[3];
myArray[0] = 32;
myArray[1] = 'A';
myArray[2] = "Hey";

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

Console.WriteLine();

Console.WriteLine(myArray[0] = +Int32.MaxValue);
Console.WriteLine((string)myArray[2] + " guys!");


//додумал додумал))