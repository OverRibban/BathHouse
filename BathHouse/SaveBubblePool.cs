using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathHouse
{
    class SaveBubblePool : BubblePool
    {
        public SaveBubblePool(int max) : base(max)
        {
            SetMax(max);
        }
        private string notification = "The pool cleaned itself";
        public override void GetIn(Swimmer joiner)
        {

        }
    }
}
