using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;


namespace Eindopdracht_Gevorderd_Programmeren
{
    class MyListStack : Stack
    {
        private MyList<int> list = new MyList<int>();
        
        public override int Pop()
        {
            if (list.GetNext() == null)
            {
                return Convert.ToInt32(list.GetItem());
                
            }
            else
            {
                return Convert.ToInt32(list.GetNext().GetItem());
            }

        }

        public override void Push(int item)
        {
            if (list.GetNext() == null)
            {
                list.next = new MyList<int>();
                list.Add(item);
            }
        }
    }
}
