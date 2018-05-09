using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_Gevorderd_Programmeren
{
    class MyList<T>
    {
       private readonly T item;
       private MyList<T> next;

        public MyList(T i)
        {
            this.item = i;
            next = null;
        }

        
        

        public MyList<T> GetNext()
        {
            return this.next;
        }

        public void Add(T i)
        {
            if(next == null)
            {
                next = new MyList<T>(i);
            } else
            {
                next.Add(i);
            }
        }
        public  T GetItem()
        {
            if(next == null)
            {
                return this.item;
            }
            else
            {
                return next.GetItem();
            }
        }
    }
}
