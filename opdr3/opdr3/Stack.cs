using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdr3
{
    class Stack<T>
    {
        private List<T> stacklist = new List<T>();

        public void Push(T item)
        {
            stacklist[0] = item;
        }

        public void Pop()
        {
            

        }

    }
}
