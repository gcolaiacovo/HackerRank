using System;
using System.Linq;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(camelcase("saveChangesInTheEditor"));
            Console.ReadLine();
        }

        static int camelcase(string s)
        {
            int returnValue = 0;

            returnValue = s.Count(n => char.IsUpper(n)) + 1;

            return returnValue;
        }
    }
}
