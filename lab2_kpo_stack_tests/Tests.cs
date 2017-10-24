using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using lab2_kpo_stack;

namespace lab2_kpo_stack_tests
{
    public class Tests
    {
        [Test()]
        public void TestPushOneElement()
        {
            NodeStack<string> stack = new NodeStack<string>();
            stack.Push("Name");
            string actual = stack.Pop();
            string excerted = "Name";
            Assert.AreEqual(excerted, actual);
        }
        [Test()]
        public void TestPushFiveElements()
        {
            NodeStack<string> stack = new NodeStack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            string actual = stack.Pop();
            string excerted = "E";
            Assert.AreEqual(excerted, actual);
        }
        [Test()]
        public void TestPopElements()
        {
            NodeStack<string> stack = new NodeStack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            string actual = stack.Pop();
            string excerted = "B";
            Assert.AreEqual(excerted, actual);
        }
        [Test()]
        public void TestPopElements2()
        {
            NodeStack<string> stack = new NodeStack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            string actual1 = stack.Pop();
            string excerted1 = "E";
            Assert.AreEqual(excerted1, actual1);

            string actual2 = stack.Pop();
            string excerted2 = "D";
            Assert.AreEqual(excerted2, actual2);

            string actual3 = stack.Pop();
            string excerted3 = "C";
            Assert.AreEqual(excerted3, actual3);
        }
        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPopException()
        {
            NodeStack<string> stack = new NodeStack<string>();
            string actual = stack.Pop();
            string excerted = "Стек пуст";
            Assert.AreEqual(excerted, actual);
        }
        [Test()]
        public void TestPeekElement()
        {
            NodeStack<string> stack = new NodeStack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            string actual = stack.Peek();
            string excerted = "E";
            Assert.AreEqual(excerted, actual);
        }
        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPeekException()
        {
            NodeStack<string> stack = new NodeStack<string>();
            string actual = stack.Peek();
            string excerted = "Стек пуст";
            Assert.AreEqual(excerted, actual);
        }

        //3

    }
}
