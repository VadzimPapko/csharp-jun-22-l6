object[] myArray = new object[3];
myArray[0] = 32;
myArray[1] = 'A';
myArray[2] = "Hey";


for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");  
}


//myArray[0] += Int32.MaxValue;   