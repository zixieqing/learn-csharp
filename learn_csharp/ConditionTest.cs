using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    class ConditionTest
    {
        static public void someTest()
        {
            Console.WriteLine($"=========================ConditionTest条件语句======================");
            int count = 1;
            while(count < 10)
            {
                Console.WriteLine($"while;count={count}");
                count++;
            };

            do
            {
                count++;
                Console.WriteLine($"do while;count={count}");
            } while (count < 12);

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"for Hello World! The counter is {counter}");
            }

            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The column is {column}");
            }
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"=========================ConditionTest条件语句======================");
        }
        
}
}
