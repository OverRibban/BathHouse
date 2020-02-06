using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathHouse
{
    class LockerRoom<T>
    {
        private List<Locker<T>> lockerList = new List<Locker<T>>();
        public void Add<T>(int id, T contents)
        {

        }
        public int Find(int id)
        {
            return id;
        }
        public bool HasThing<T>(T contents)
        {
            foreach (Locker<T> item in lockerList)
            {
                if (item.GetContents() = contents)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
