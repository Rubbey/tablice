using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice
{
    class Program
    {
        static void Main(string[] args)
        {

            // deklaracja 1
            int[] tab1 = { 4, 3, 5, 2, 1 };

            foreach(int element in tab1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // deklaracja 2
            int[] tab2;
            tab2 = new int[4];

            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = i * i;
            }
            foreach (int element in tab2)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // deklaracja 3

            int[] tab3 = new int[6] { 4, 6, 2, 1, 9, 3 };

            foreach (int element in tab3)
            {
                Console.WriteLine(element);
            }






        }
    }
}
