using System;
using System.Collections.Generic;

namespace Josephus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<short> NumOfSoliders = new List<short>
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            short ThirdManVerifier = 1;
            while (NumOfSoliders.Count > 1)
            {
                for (int i = 0; i < NumOfSoliders.Count; i++)
                {
                    if (ThirdManVerifier == 3)
                    {
                        ThirdManVerifier = 1;
                        NumOfSoliders.RemoveAt(i);
                    }
                    ThirdManVerifier++;
                }
            }
            Console.WriteLine(NumOfSoliders[0].ToString());
            Console.ReadLine();
        }
    }
}
