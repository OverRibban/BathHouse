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
            contents.
            lockerList.Add(contents);
        }
        public int Find<T>(int id)
        {
            return lockerList.IndexOf;
        }
        public bool HasThing<T>(T contents)
        {
            foreach (Locker<T> item in lockerList)
            {
                if (item.GetContents() == contents)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
