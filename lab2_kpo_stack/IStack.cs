using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_kpo_stack
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
        T Peek();
    }
}
