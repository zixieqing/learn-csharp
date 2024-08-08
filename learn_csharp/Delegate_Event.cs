using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    //委托就像是一串鞭炮。将函数链接与取消或者触发，可以自由使用。
    //但是事件限定了只能由声明事件的类来触发。

    /*
     * 委托是一种类型
    委托是一种类型与返回值相同函数的链表
    委托使用+=，=，-=三个符号操作链表里的函数
    调用委托就会依次调用委托链表里的所有函数
    委托返回值默认是最后一个添加的函数返回值
     */
    class Delegate_Event
    {
        
        delegate void func(string f);
        static func l;
        static void showName(string name)
        {
            Console.WriteLine("你先输出了名字，参数：" + name);
        }
        static void showTitle(string title)
        {
            Console.WriteLine("你又输出了主题，参数：" + title);
        }
        static void run(func l)
        {
            l("一个参数");
        }
        public static void delegateUse()
        {
            Console.WriteLine($"=========================Delegate event 委托与事件======================");
            l += showName;
            l += showTitle;
            run(l);
        }
    }
    delegate void func(string name);
    class Person
    {
        string name;
        public event func died;
        public event func fellFull;
        public event func fellHungry;
        public Person(string name)
        {
            this.name = name;
        }

        public void EatDonut(int i)
        {
            if (i <= 10)
            {
                fellHungry(name);
            }
            else
            {
                if (i <= 100)
                {
                    fellFull(name);
                }
                else
                {
                    if (i > 100)
                    {
                        died(name);
                    }
                }
            }
        }
        public void taiGuan(string name)
        {
            Console.WriteLine(this.name + "收到" + name + "死了，开始抬棺！奏乐！！");
        }
        public void seeHungry(string name)
        {
            Console.WriteLine(this.name + "看到" + name + "还很饿");
        }
        public void seeFull(string name)
        {
            Console.WriteLine(this.name + "看到" + name + "吃饱了");
        }

        static public void blackPersonPlay()
        {
            Person Hei1 = new Person("黑人小哥1");
            Person Hei2 = new Person("黑人小哥2");
            Person Hei3 = new Person("黑人小哥3");
            Person Hei4 = new Person("黑人小哥4");
            Person ming = new Person("小明");
            ming.died += Hei1.taiGuan;
            ming.died += Hei2.taiGuan;
            ming.died += Hei3.taiGuan;
            ming.died += Hei4.taiGuan;
            ming.fellFull += Hei1.seeFull;
            ming.fellFull += Hei2.seeFull;
            ming.fellFull += Hei3.seeFull;
            ming.fellFull += Hei4.seeFull;
            ming.fellHungry += Hei1.seeHungry;
            ming.fellHungry += Hei2.seeHungry;
            ming.fellHungry += Hei3.seeHungry;
            ming.fellHungry += Hei4.seeHungry;
            //ming.EatDonut(10);
            int i;

            try
            {
                while (true)
                {
                    Console.WriteLine("请输入小明吃甜甜圈的数量：");
                    i = int.Parse(Console.ReadLine());
                    ming.EatDonut(i);
                    Console.ReadKey();
                    //Console.Clear();
                    break;
                }
            }
            catch (Exception e)
            {

            }
            Console.WriteLine($"=========================Delegate event 委托与事件======================");
        }
    }
}
