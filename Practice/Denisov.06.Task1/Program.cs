string[] arr = new string[0];
var myArray = Array.Empty<string>();
//if it will be empty console that means threre no elements in array
foreach (var item in arr)
{
    Console.WriteLine($"First array elements: {item}"); // empty
}
foreach (var item in myArray)
{
    Console.WriteLine($"Second array elements: {item}"); // empty
    
}