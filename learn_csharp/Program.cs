// See https://aka.ms/new-console-template for more information
using System;

using learn_csharp;

class Program
{
    //C# 程序中只能有一个入口点。 如果多个类包含 Main 方法，必须使用 StartupObject 编译器选项来编译程序，以指定将哪个 Main 方法用作入口点。
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //数学运算
        MathTest.someTest();
        //数学运算
        ConditionTest.someTest();
        //List
        ListTest.someTest();

        //使用委托
        Delegate_Event.delegateUse();

        //黑人抬棺的实例
        Person.blackPersonPlay();

      
    }
}