using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdr2
{
    class Minion : Person
    {
        private string weakness;

    public Minion(string name, string weakness)
        {
            this.name = name;
            this.weakness = weakness;
        }

        public string getName()
        {
            return this.name;
        }
        public string getWeakness()
        {
            return weakness;
        }
            
    }
}
