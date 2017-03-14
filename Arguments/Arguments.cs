using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutA.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            for (int i = 1; i < args.Length; i++)
            {
                Console.WriteLine("**************");
                Console.WriteLine("Args {0} : {1}", i , args[i]);
                Console.WriteLine("**************");
            }
            string[] myArgs = Environment.GetCommandLineArgs();

            Console.WriteLine(string.Join(", ", myArgs));

            SayHello();

            Console.ReadLine();
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
}
