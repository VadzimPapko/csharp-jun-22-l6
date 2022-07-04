object[] Array1 = new object[] { 32, 'A', "Hey"};

int value = int.MaxValue;

object[] Array2 = new object[] { value, ,"guys"};

object[] newArray = new object[3];

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = Array1[i] + Array2[i];

    Console.Write($"{newArray[i]} ");
}