using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdr2
{
    class Program
    {
        static void Main(string[] args)
        {

            Villain ozymandias = new Villain("Adrian Veidt", 60);
            Villain joker = new Villain("Mr. J", 70);
            Person robin = new Hero("Jason Todd", joker,null, 30);
            Hero batman = new Hero("Bruce Wayne", joker, robin, 40);
            batman.addStrength("Intelligence");
            batman.addStrength("Wealth");
            Person rorschach = new Hero("Walter Joseph Kovacs", ozymandias,null, 50);
            Villain gru = new Villain("Gru", 90);
            Minion bob = new Minion("Bob","Dumb");
            Minion kevin = new Minion("Kevin","Dumb");
            Minion stuart = new Minion("Stuart", "Dumb");
            gru.addMinion(bob);
            gru.addMinion(kevin);
            gru.addMinion(stuart);

            Console.WriteLine("BATMAN");
            Console.WriteLine(batman.getName());
            foreach (string strenght in batman.getKrachten())
            {
                Console.WriteLine(strenght);
            }
            Console.WriteLine(batman.getArchnemesis().getName());
            Console.WriteLine(batman.getArchnemesis().getEvilness());

            Console.WriteLine("GRU");
            Console.WriteLine(gru.getName());
            foreach (Minion minion in gru.getMinions())
            {
                Console.WriteLine(minion.getName());
                Console.WriteLine(minion.getWeakness());
            }
            Console.ReadKey();
        }
    }
}
