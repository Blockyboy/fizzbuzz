using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string fizz = "fizz";
            string buzz = "buzz";
            int numberLimit = 100;

            for(int i = 0; i < numberLimit; ++i)
            {
                string output = "";
                if (i % 3 == 0)
                {
                    output += fizz;
                }
                if (i % 5 == 0)
                {
                    output += buzz;
                }

                Console.WriteLine(Convert.ToString(i) + ": " + output);
            }
        }
    }
}
