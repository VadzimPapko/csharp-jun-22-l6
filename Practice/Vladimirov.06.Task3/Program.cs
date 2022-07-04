using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myMass = new int[133];
            Random random = new Random();
            for( int i = 0; i < myMass.Length; i++ )
            {
                myMass[i] = random.Next(0,100);
            }

            int index = 0;
            int Maxel = myMass[index];
            for( int i = 0; i < myMass.Length; i++ )
            {
                if( Maxel < myMass[i])
                {
                    Maxel = myMass[i];
                    index = i;
                }
            }
            Console.WriteLine("Максимальный элемент: {0} его индекс {1}", Maxel, index );
            foreach(var el in myMass)
            {
                Console.Write(el+" ");
            }
        }
    }
}