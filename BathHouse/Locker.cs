using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathHouse
{
    class Locker<T>
    {
        private int id;
        private T contents;
        public Locker(T contents) {
            this.contents = contents;
        }
        public T GetContents()
        {
            return contents;
        }
           
    }
}
