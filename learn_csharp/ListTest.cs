using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    class ListTest
    {
        static public void someTest()
        {
            Console.WriteLine($"=========================ListTest:列表======================");
            var names = new List<string> { "<name>", "zhangsan","lisi","liuxiang"};
            //增
            names.Add("Liming");
            //删
            names.Remove("lisi");
            foreach (var name in names){
                Console.WriteLine(name.ToUpper());
            }
            //改
            names[0] = "zhangsan2";
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it");
            //查询
            if (names.IndexOf("lisi") != -1)
                Console.WriteLine("is exist");
            //排序
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //其他类型的列表
            var fibonacciNumbers = new List<int> { 1, 1 };
        }
        
            

    }
}
