object[] array = new object[3] { 32, 'A', "Hey" };

Console.Write("Was ");
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine();

double tecInt = Convert.ToDouble(array[0]);

array[0]=tecInt+Int32.MaxValue;

array[2]+=" guys!";

Console.Write("Became ");
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine();