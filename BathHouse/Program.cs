using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //SwimmerTest(args);
            BubblePoolTest(args);
        }
        public static void SwimmerTest(String[] args)
        {
            Swimmer johan = new Swimmer("Johan");
            Swimmer magnus = new Swimmer("Magnus", new BathingSuit());
            johan.SetSuit(new BathingSuit());
            magnus.SetSuit(null);
            ProfessionalSwimmer eric = new ProfessionalSwimmer("Eric", new BathingSuit());
            ProfessionalSwimmer simon = new ProfessionalSwimmer("Simon", new BathingSuit());
            eric.SetSuit(null);
            List<Swimmer> swimmers = new List<Swimmer>();
            swimmers.Add(johan);
            swimmers.Add(new YoungSwimmer("Christoffer", new BathingSuit()));
            swimmers.Add(new YoungSwimmer("Christoffer", null));
            foreach (Swimmer sw in swimmers)
            {
                Console.WriteLine(sw.Swim());
            }
            foreach (Swimmer sw in swimmers)
            {
                Console.WriteLine(sw.Swim());
            }
            Console.ReadKey();


        }
        public static void BubblePoolTest(String[] args)
        {
            BubblePool newPool = new BubblePool(5);
            Swimmer johan = new Swimmer("Johan");
            for (int i = 4; (i > 0); i--)
            {
                newPool.GetIn(new Swimmer("Johan"));
            }
            try
            {
                newPool.GetIn(johan);
                // här kastas PoolDirtyException.
            }
            catch
            {
                Console.WriteLine("All swimmers has to leave the pool!");
                newPool.Clean();
            }
            newPool.GetIn(johan);
            newPool.GetIn(new Swimmer("Johan"));
            // detta borde alltså inte vara något problem längre.
            Console.ReadKey();
        }
        public static void LockerRoomTest(String[] args)
        {
            LockerRoom<String> stringLockers = new LockerRoom<String>();
            stringLockers.Add(1, new Locker<String>("junk"));
            stringLockers.Add(3, new Locker<String>("towel"));
            stringLockers.Add(4, new Locker<String>("goggles"));
            stringLockers.Add(190, new Locker<String>("snorkle"));
            Locker<String> locker = stringLockers.Find(3);
            Console.WriteLine(locker.GetContents());
            // Vi borde fått ut "towel" i terminalen
            if (stringLockers.HasThing("goggles"))
            {
                Console.WriteLine("We found goggles in a locker!");
                // borde komma ut
            }
            if (stringLockers.HasThing("sandwich"))
            {
                Console.WriteLine("We found a sandwich, ugh!");
                // borde INTE komma ut
            }
            ListOfObjects<string> list = new ListOfObjects<string>();
            list.AddObject("Forty-two");
        }
    }
}
