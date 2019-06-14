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

            int zz = countries.Aggregate(0, (current, item) => current + item.Length);

            Console.WriteLine(zz);

            //
            int[] numbers = { 1, 2, 3, 4 };
            //seed parameter
            int total = numbers.Aggregate( 10, (num1, num2) => num1 + num2);
            Console.WriteLine(total);

            //without aggregate
            int answer = 10;
            foreach (int num in numbers)
            {
                answer = answer + num;
            }

            Console.WriteLine(answer * 2);

            //mutiple parameter
            //3 overloads
            Console.WriteLine(numbers.Aggregate(10, (sum, next) => sum + next, sum => sum * 2));
        }
    }
}
