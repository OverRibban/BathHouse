using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BathHouse
{
    class Swimmer
    {
        private string Name { get; set; }
        private BathingSuit Suit { get; set; }
        /// <summary>
        /// Constructor which only requires name parameter
        /// </summary>
        /// <param name="name"></param>
        public Swimmer(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Constructor using name and suit parameter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="suit"></param>
        public Swimmer(string name, [Optional] BathingSuit suit)
        {
            this.Name = name;
            this.Suit = suit;
        }
        /// <summary>
        /// Sets private variable name in subclasses
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Returns string for swim
        /// </summary>
        /// <returns></returns>
        public virtual string Swim()
        {
            return "Splish splash - it's so fun in the bath!";
        }
        /// <summary>
        /// Sets swimmer suit
        /// </summary>
        /// <param name="suit"></param>
        public void SetSuit(BathingSuit suit)
        {
            this.Suit = suit;
        }
    }
}
