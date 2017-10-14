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
            NodeStack<int> stack = new NodeStack<int>();
            stack.Push(0);
            stack.Push(1);
            //
            stack.Push(7);
            stack.Push(2);
            stack.Push(27);
            stack.Push(22);
            stack.Push(17);
            stack.Push(12);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_____");
            int header = stack.Peek();
            Console.WriteLine($"Stack head: {header}");
            Console.WriteLine("_____");
            header = stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("______________________________________");

            Console.WriteLine("Clone: ");
            NodeStack<int> stack2 = (NodeStack<int>)stack.Clone();

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("_____");
            int header2 = stack.Peek();
            Console.WriteLine($"Stack head: {header2}");
            Console.WriteLine("_____");
            header2 = stack.Pop();
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("______________________________________");

            Console.ReadKey();
        }
    }
}
