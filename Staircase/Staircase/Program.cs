using System;
using System.Text;

namespace Staircase
{
    class Program
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(' ', n - (i + 1));
                sb.Append('#', i + 1);
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }

        static void Main(string[] args)
        {
            staircase(15);
            Console.ReadLine();
        }
    }
}
