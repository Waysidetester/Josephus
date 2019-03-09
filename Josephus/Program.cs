using System;
using System.Collections.Generic;

namespace Josephus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<short> NumOfSoliders = new List<short>
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            short ThirdManVerifier = 1;
            while (NumOfSoliders.Count > 1)
            {
                List<int> RemovedIndexPosition = new List<int>();
                for (int i = 0; i < NumOfSoliders.Count; i++)
                {
                    if (ThirdManVerifier == 3)
                    {
                        ThirdManVerifier = 1;
                        Console.WriteLine(NumOfSoliders[i]);
                        RemovedIndexPosition.Add(i);

                    }
                    else
                    {
                        ThirdManVerifier++;
                    }
                }
                RemovedIndexPosition.Reverse();
                foreach (var index in RemovedIndexPosition)
                {
                    NumOfSoliders.RemoveAt(index);
                }
            }
            Console.WriteLine("End: " + NumOfSoliders[0].ToString());
            Console.ReadLine();
        }
    }
}
