using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_Gevorderd_Programmeren
{
    class MyList<T>
    {
      private  T item;
      public MyList<T> next;

       

        
        

        public MyList<T> GetNext()
        {
            return this.next;
        }

        public void Add(T i)
        {
            if(next == null)
            {
                next = new MyList<T>();
                next.item = i;
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
