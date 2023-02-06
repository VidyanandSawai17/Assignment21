using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
        static void Main(string[] args)
        {

        /*  Generic Collections in C#

            Generic means same type of data
            In generic collections we can process similar type of objects
            Generic collection is type safe
            Boxing & unboxing is not required
            It can process objects dynamically

            Advantage of using generic collections
            Type safe
            Better performance
            Dynamically process the objects



            Namespace: System.Collections.Generic

            Classes
            List<T>
            Stack<T>
            Queue<T>
            Dictionary<TKey, TValue>
            SortedList<TKey, TValue>
            HashSet<T>


            < T >  → type for placeholder

            Type → class, int, float, string,double….   */



            List<int> ilist = new List<int>();
            ilist.Add(1);
            ilist.Add(2);
            ilist.Add(3);
            // insert, addrange,removerange,remove, removeat,sort , reverse, -> count ,capacity
            List<string> slist = new List<string>();
            slist.Add("Pune");
            slist.Add("Mumbai");

            foreach (string item in slist)
            {
                Console.WriteLine(item);
            }
            List<Product> productlist = new List<Product>();
            productlist.Add(new Product { Id = 1, Name = "mouse", Price = 899 });

            foreach (Product p in productlist)
            {
                Console.WriteLine();
            }
            List<double> dlist = new List<double>();
            dlist.Add(45222.787);

            foreach (int i in ilist)
            {
                Console.WriteLine(i);
            }

            Stack<int> stack = new Stack<int>();
            //Push ,Pop, Peek

            Queue<string> queue = new Queue<string>();
            //Enqueue, Dequeue,peek
        



            /* HashSet →
            It wont allow duplicate elements in to the collection
            Elements in to the HashSet are not defined.
            Do math operations like union, intersect, except
            */

            HashSet<int> hashset = new HashSet<int>();

            hashset.Add(1);
            hashset.Add(2);
            hashset.Add(3);
            hashset.Add(3);

            foreach (int item in hashset)
            {
                Console.WriteLine(item);
            }
        



        
            HashSet<string> set1 = new HashSet<string>();

            set1.Add("C");
            set1.Add("C++");
            set1.Add("C#");
            set1.Add("Java");
            set1.Add("Ruby");

            HashSet<string> set2 = new HashSet<string>();

            set2.Add("PHP");
            set2.Add("C++");
            set2.Add("Perl");
            set2.Add("Java");

            // union on hastset

            // set1.UnionWith(set2);
            //  set1.IntersectWith(set2);
            set1.ExceptWith(set2);
            foreach (string s in set1)
            {
                Console.WriteLine(s);
            }
        
        }
    }
}
