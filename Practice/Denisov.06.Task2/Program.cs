object[] array1 = new object[3] { 32, 'A', " Hey" };
foreach (var item in array1)
{
    Console.Write($"Array item: {item}" + " ");
}
Console.WriteLine("\n");
object newArrayItem = array1[0];
Int32 maxValArg = Int32.MaxValue;
newArrayItem = (Int32)array1[0] + maxValArg;
array1[0] = newArrayItem;
array1[2] = array1[2] + " guys!!";
foreach (var item in array1)
{
    Console.Write($"New array item: {item}" + " ");
}