using System;
using MyLibrary;
using System.Buffer;
namespace MyApplication
{
    class MyClass
    {
        
        static void Main(string[] args)
        {
            HelloWorld.WriteHello();
            Console.WriteLine("Ange ditt namn och avsluta med enter.");
            var name = Console.ReadLine();
            Console.WriteLine("Hej " + name + "!");
            Console.ReadKey();

        }
    }
}
