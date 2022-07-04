object[] newArray = new object[3] { 32, 'A', "Hey" };
Console.Write(newArray[0]);
Console.Write(newArray[1]);
Console.Write(newArray[2]);

newArray[0] = 32 + Convert.ToDecimal(int.MaxValue);
newArray[2] = "Hey " + "Guys";
Console.Write(newArray[0]);
Console.Write(newArray[1]);
Console.Write(newArray[2]);