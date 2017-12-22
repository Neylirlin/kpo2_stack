using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

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
            Console.WriteLine("______________________________________");

            Data d = new Data();
            Person person1 = new Person("Lina", 14);
            Person person2 = new Person("Alica", 21);
            Person person3 = new Person("Kate", 25);
            Person person4 = new Person("Zoe", 8);
            Person person5 = new Person("Lux", 20);
            Person person6 = new Person("Karolina", 15);
            NodeStack<Person> persons = new NodeStack<Person>();
            persons.Push(person1);
            persons.Push(person2);
            persons.Push(person3);
            persons.Push(person4);
            persons.Push(person5);
            persons.Push(person6);

            d.Serialization(persons);

            NodeStack<Person> new_stack = d.Deserialization("person.json");

            Console.ReadKey();
        }
    }
}
