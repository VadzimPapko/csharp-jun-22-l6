

object[] arr = new object[3];

long num = 32;
arr[0] = num;

char c = 'A';
arr[1] = c;

string s = "Hey";
arr[2] = s;

for (int i = 0; i < 3; i++)
    Console.WriteLine($"{arr[i].ToString()}");


arr[0] = (long)arr[0] + Int32.MaxValue;
arr[2] = (string)arr[2] + " guys!";

for (int i = 0; i < 3; i++)
    Console.WriteLine($"{arr[i].ToString()}");