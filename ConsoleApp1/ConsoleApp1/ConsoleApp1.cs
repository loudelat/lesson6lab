using System;
using alias2a = ConsoleApp2.Program2;
using alias2b = ConsoleApp22.Program22;
using ConsoleApp22;

class UsingDirectives
{
    public static void Main(string[] args)
    {
        alias2a.print();
        alias2b.print();
        ConsoleApp1.Program1.print();
        ConsoleApp11.Program11.print();
        ConsoleApp22.Program22a.print();
    }
}

namespace ConsoleApp1
{
    class Program1
    {
        public static void print()
        {
            Console.WriteLine("This is from the ConsoleApp1 namespace Program1");
        }
    }
}

namespace ConsoleApp11
 {
     class Program11
        {
            public static void print()
            {
                Console.WriteLine("This is from the ConsoleApp11 namespace Program11");
            }
        }
 }