using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] massObj = new object[3] { 32, 'A', " Hey"};
            foreach (var mass in massObj)
            {
                Console.Write(mass);
            }
            Console.WriteLine();
            massObj[0] = (Int32)massObj[0] + Int32.MaxValue;
            massObj[2] = massObj[2] + " guys";
            foreach (var mass in massObj)
            {
                Console.Write(mass);
            }



        }
    }
}