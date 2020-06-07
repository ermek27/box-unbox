using System;
using System.Collections.Generic;

namespace BoxingProj
{
    class Program
    {

        static List<object> emptylist()
        {
            return new List<object>()
            {
                7,
                28,
                -1,
                true,
                "chair"
            };
        }
        static void ObjList(List<object> words)
        {
            int num = 0;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] is int)
                {
                    num += (int) words[i];
                }
            }
            Console.WriteLine($"the sum is:\n{num}");
        }




        static void Main(string[] args)
        {
            ObjList( emptylist() );
        }
    }
}
