// See https://aka.ms/new-console-template for more information

// Create array

object[] myObjArray = {32, 'A', "Hey"};

foreach (var item in myObjArray)
{
    Console.Write(item + "\t");
}
Console.WriteLine("\n");

myObjArray[0] = (int)myObjArray[0] + Int32.MaxValue;
myObjArray[2] = myObjArray[2] + " guys!";

foreach (var item in myObjArray)
{
    Console.Write(item + "\t");
}
Console.ReadKey();