using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_kpo_stack
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }

    public class NodeStack<T> : IStack<T>, IEnumerable<T>, ICloneable
    {
        Node<T> head;
        int count;

        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public int Count
        {
            get { return count; }
        }

        public void Push(T item)
        {
            // увеличиваем стек
            Node<T> node = new Node<T>(item);
            node.Next = head; // переустанавливаем верхушку стека на новый элемент
            head = node;
            count++;
        }
        public T Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            else
            {
                Node<T> temp = head;
                head = head.Next; // переустанавливаем верхушку стека на следующий элемент
                count--;
                return temp.Data;
            }
        }
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            else
            {
                return head.Data;
            }
        }
        //--------------------------------------------------------
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        //-------------------------------------------------------

        public object Clone() //поверхностное (неглубокое) копирование
        {
            return this.MemberwiseClone();
        }

        //-------------------------------------------------------

    }
}
