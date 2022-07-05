List<object> mas = new List<object>();
mas.Add(32);
mas.Add('A');
mas.Add("Hey");

foreach (var item in mas)
{
    switch (item)
    {
        case int num when num == 32:
            Console.WriteLine(num + int.MaxValue);
            break;
        case string str when str == "Hey":
            Console.WriteLine("Hey" + " guys!");
            break;
    }
}