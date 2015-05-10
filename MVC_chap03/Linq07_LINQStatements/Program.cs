using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq07_LINQStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> list2 = new List<int>() { 6, 4, 2, 7, 9, 0 };

            // join query by statement.
            var query = from item1 in list1
                        join item2 in list2 on item1 equals item2
                        select item2;

            foreach (var q in query.Where((c, c2) => c > 2))
                Console.Write("{0} ", q);

            Console.WriteLine();

            var query2 = from bigger in list1
                         select bigger;

            foreach (var q in query2.Where(c=>c>2 && c<6))
                Console.Write("{0} ",q);

            Console.ReadLine();
        }
    }
}
