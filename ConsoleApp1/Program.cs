using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int[] m = new int[] { x, y };
            //Console.WriteLine(x);
            Test(ref m);
            foreach (var item in m)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(x);

            MyList<string> myList = new MyList<string>();
            myList.Add("2");
            myList.Add("3");
            Console.WriteLine(myList.Get(1));

            Console.ReadKey();
        }
        static void Test(ref int[] m)
        {
            m = new int[] { m[0], m[1] };
            for (int i = 0; i < m.Length; i++)
            {
                m[i]++;
            }
        }
        static void Test(int x)
        {
            x++;
        }
    }
}
