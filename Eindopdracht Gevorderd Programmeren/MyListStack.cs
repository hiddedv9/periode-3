using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;


namespace Eindopdracht_Gevorderd_Programmeren
{
    class MyListStack<T> : Stack<T>
    {
        private MyList<T> list;
        
        public override T Pop()
        {
            if (list.GetNext() == null)
            {
                return list.GetItem();
                
            }
            else
            {
                return list.GetNext().GetItem();
            }

        }

        public override void Push(T item)
        {
            if(list.GetNext() == null) { }
        }
    }
}
