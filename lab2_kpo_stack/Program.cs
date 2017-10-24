using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_kpo_stack
{
    class Program
    {
        public static int Max(NodeStack<int> stack)
        {
            int max = stack.Peek();
            foreach (int x in stack)
            {
                max = x;
            }
            return max;
        }

        static void Main(string[] args)
        {
            NodeStack<int> stack = new NodeStack<int>();

            stack.Push(-1);
            stack.Push(-2);
            stack.Push(3);
            stack.Push(-3);
            stack.Push(2);
            stack.Push(4);

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
            Console.WriteLine("______________________________________");


            int max = stack.Max();

            foreach (int m in stack)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine();
            Console.WriteLine("Max: " + max);

            Console.ReadKey();
        }
    }
}
