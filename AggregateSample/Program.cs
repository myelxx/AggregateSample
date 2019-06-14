using System;
using System.Linq;

namespace AggregateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //without linq aggregate
            string[] countries = { "Philippines", "US", "Canada", "France"};
            string result = string.Empty;

            foreach(string str in countries)
            {
                result = result + str + ", ";
            }

            Console.WriteLine(result);

            //with linq aggregate
            string result1 = countries.Aggregate( (a,b) => a + ", " + b);
            Console.WriteLine(result1);
        }
    }
}
