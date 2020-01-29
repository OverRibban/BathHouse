using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathHouse
{
    class Swimmer
    {
        public Swimmer(string name, BathingSuit suit)
        {
            this.name = name;
            this.suit = suit;
        }
        private string name;
        private BathingSuit suit;

        public string Swim()
        {
            return "Splish splash - it's so fun in the bath!";
        }

        public void SetSuit(BathingSuit suit)
        {
            this.suit = suit;
        }
    }
}
