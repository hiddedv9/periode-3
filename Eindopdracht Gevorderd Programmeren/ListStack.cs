using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace Eindopdracht_Gevorderd_Programmeren
{
    class ListStack<T> : Stack<T>
    {
        List<T> list = new List<T>();


        public override void Push(T item)
        {
            list.Add(item);
        }

        public override T Pop()
        {
            T item = list[list.Count-1];
            list.Remove(item);
            return item;
        }

        
    }
}
