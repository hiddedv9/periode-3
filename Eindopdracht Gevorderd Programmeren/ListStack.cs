using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace Eindopdracht_Gevorderd_Programmeren
{
    class ListStack : Stack
    {
        List<int> list = new List<int>();

        public  override void Push(int item)
        {
            list.Add(item);
        }

        

        public override int Pop()
        {
            int item = list[list.Count-1];
            list.Remove(item);
            return item;
        }

        
    }
}
