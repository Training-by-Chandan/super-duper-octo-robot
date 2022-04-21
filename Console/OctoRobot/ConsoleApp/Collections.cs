using System.Collections; //non-generic
using System.Collections.Generic; //for generic
using System.Linq;

namespace Octo.Robot
{
    public class Collection
    {
        public static void NonGeneric()
        {
            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push("1");
            s1.Push(new Animal());
        }

        public static void Generic()
        {
            Stack<int> sInt = new Stack<int>();
            sInt.Push(1);

            //list
            List<int> l1 = new List<int>();
            l1.Add(1);
            l1.Add(1);
            l1.Add(2);
            l1.Add(2);
            l1.Add(3);
            l1.Add(3);
            l1.Add(4);

            var arr = l1.ToArray();
        }
    }
}