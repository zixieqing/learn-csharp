using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
     class AllTypes
    {
        public AllTypes() {
            // Declaration only:
            float temperature;
            string name;
            AllTypes myClass;

            // Declaration with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;
            //值类型
            byte b = byte.MaxValue;
            byte num = 0xA;
            int i = 5;
            char c = 'Z';
            //struct\enum


            //引用类型
            //定义为 class、record、delegate、数组或 interface 的类型是 reference type。

        }

        public enum FileMode
        {
            CreateNew = 1,
            Create = 2,
            Open = 3,
            OpenOrCreate = 4,
            Truncate = 5,
            Append = 6,
        }

        public struct Coords
        {
            public int x, y;

            public Coords(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

    }
    struct YourStruct
    {
    }

    interface IYourInterface
    {
    }

    delegate int YourDelegate();

    enum YourEnum
    {
    }

    namespace YourNestedNamespace
    {
        struct YourStruct
        {
        }
    }
}
