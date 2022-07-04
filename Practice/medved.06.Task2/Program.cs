object[] myArray = new object[3];
myArray[0] = 32;
myArray[1] = 'A';
myArray[2] = "Hey";


for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

Console.WriteLine();

object newItem = myArray[0];


int newNum = (int)myArray[0] + int.MaxValue;
string str = (string)myArray[2] + " guys!";
Console.WriteLine(newNum);
Console.WriteLine(str);