using System;

namespace Uppgift5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Axel", "Edvin", "Gud", "Lucifer", "Ceasar" };
            for(int i = 0;i < namn.Length; i++)
            {
                Array.Sort(namn);
                Console.WriteLine(namn[i]);
            }
        }
    }
}

