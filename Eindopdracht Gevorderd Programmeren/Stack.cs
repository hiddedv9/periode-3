using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_Gevorderd_Programmeren
{
    public abstract class Stack
    {
        //virtual method zodat we hem aan kunnen passen voor gebruik met generic in myliststack
        public abstract void Push(int item);
       
        public abstract int Pop();


    }
}
