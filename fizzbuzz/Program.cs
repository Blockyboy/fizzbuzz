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
            bool isFizzOrBuzz = false;
            string output = "";

            Console.WriteLine("FizzBuzz");

            for (int i = 0; i < numberLimit; ++i)
            {
                output = "";
                isFizzOrBuzz = false;
                if (i % 3 == 0)
                {
                    output += fizz;
                    isFizzOrBuzz = true;
                }
                if (i % 5 == 0)
                {
                    output += buzz;
                    isFizzOrBuzz = true;
                }

                if (isFizzOrBuzz)
                {
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine(Convert.ToString(i));
                }
            }
        }
    }
}
