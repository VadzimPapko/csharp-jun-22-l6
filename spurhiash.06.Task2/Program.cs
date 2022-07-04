string[] arr = new string[3];
arr[0] = Convert.ToString(32);
arr[1] = Convert.ToString('A');
arr[2] = Convert.ToString("Hey");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
}

Console.WriteLine();

arr[0] = arr[0] + int.MaxValue;
arr[2] = ($"{arr[2]} + guys");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}