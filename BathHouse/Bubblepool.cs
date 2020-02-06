using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathHouse
{
        class BubblePool
        {
            private List<Swimmer> people = new List<Swimmer>();
            private int max;
            private int dirt;
            public BubblePool(int max)
            {
                this.max = max;
                this.dirt = 0;
            }
            public void SetMax(int max)
        {
            this.max = max;
        }
            public virtual void GetIn(Swimmer joiner)
            {
                this.people.Add(joiner);
                this.GetDirtier();
            }
            public virtual void GetOut(Swimmer leaver)
            {
                this.people.Remove(leaver);
                this.GetDirtier();
            }
            public void Clean()
            {
                this.people.Clear();
                this.dirt = 0;
            }
            private void GetDirtier()
            {
                this.dirt++;
                if ((this.dirt == this.max))
                {
                    throw new PoolDirtyException("Pool became dirty!");
                }
            }
        }
    }