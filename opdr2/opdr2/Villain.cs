using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdr2
{
    class Villain : Person, IheeftKrachten
    {

        private List<Minion> minions = new List<Minion>();
        private List<string> krachten = new List<string>();

        public Villain(string name, int evilness)
        {
            this.name = name;
            this.evilness = evilness;
        }
        public string getName()
        {
            return this.name;
        }

        public void addMinion(Minion minion)
        {
            minions.Add(minion);
        }
        public int getEvilness()
        {
            return this.evilness;
        }

        public List<Minion> getMinions()
        {
            return this.minions;
        }
        public void addStrength(string kracht)
        {
            krachten.Add(kracht);
        }

        public List<string> getKrachten()
        {
            return krachten;
        }
    }
}
