using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_kpo_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeStack<string> stack = new NodeStack<string>();
            stack.Push("Tom");
            stack.Push("Alice");
            stack.Push("Bob");
            stack.Push("Kate");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_____");
            string header = stack.Peek();
            Console.WriteLine($"Stack head: {header}");
            Console.WriteLine("_____");
            header = stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("______________________________________");
            Console.ReadKey();
        }
    }
}
