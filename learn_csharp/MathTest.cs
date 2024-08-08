using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    class MathTest
    {
        static public void someTest()
        {
            Console.WriteLine($"=========================MathTest数学运算======================");
            //int
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            //========================================最大值，最小值推导过程=================================================
            //无符号int;unsigned int 4个字节；1个字节8位；即2^32 -1
            //00000000000000000000000000-11111111111111111111111111111111 =>     0->2^32-1

            //有符号int，；-2^31 -> 2^31-1 当符号位为1时，表示负数;当符号位为0时，表示负数
            //10000000 00000000 00000000 00000000-0111 1111 1111 1111 1111 1111 1111 1111  =>   -2^31-> 2^31-1


            //0001 0*2^3 + 0*2^3 + 0*2^2 + 1* 2^0 = 1 计算方法
            //10000000 00000000 00000000 00000000 = 1*2^31+0*2^30+...+0*2^0 = 2^31 由于符号位为1 =》  -2^31
            //0111 1111 1111 1111 1111 1111 1111 1111  =  0*2^31 +...+ 1*2^0 = ;用等比数列公式求和：2^31 -1
            //========================================最大值，最小值推导过程=================================================
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");


            //double
            double a1 = 7;
            double b1 = 4;
            double c1 = 3;
            double d1 = (a1 + b1) / c1;
            Console.WriteLine(d1);
            //10^308 - 10^-308
            double max1 = double.MaxValue;
            double min1 = double.MinValue;
            Console.WriteLine($"The range of double is {min1} to {max1}");


            double third = 3.0 / 10.0;
            double third2 = 1.0 / 3.0;//浮点数除法
            double third3 = 1 / 3; //整数除法，结果会向下取整
            Console.WriteLine($"third:{third}---{third2}---{third3}");

            decimal mind = decimal.MinValue;
            decimal maxd = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {mind} to {maxd}");


            Console.WriteLine($"compare double decimal");
            double ad = 1.0;
            double bd= 3.0;
            Console.WriteLine(ad / bd);//≈0.3333333333333333


            decimal cd = 1.0M;
            decimal dd = 3.0M;
            Console.WriteLine(cd / dd);//≈0.3333333333333333333333333333
            /*
              double 是一种浮点数类型，通常使用 64 位来存储。它采用科学记数法表示，可以表示非常大的或非常小的数，但在精确度上可能会有损失
              decimal 是一种高精度数据类型，通常使用 128 位来存储，特别设计用于需要高精度的计算（例如财务计算）
             */

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);

            //  / & %(取余）
            Console.WriteLine($"{3/5} & {3%5}");

            Console.WriteLine($"=========================MathTest数学运算======================");

        }
    }
}
