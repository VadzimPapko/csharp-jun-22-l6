// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

object[] arr = new object[3] {32, 'A', "Hey"};
arr[0] =+ Int32.MaxValue;
arr[2] = (string)arr[2] + " guys!";
Console.Write(arr[0]);
Console.Write(arr[1]);
Console.Write(arr[2]);