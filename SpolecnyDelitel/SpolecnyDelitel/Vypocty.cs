using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpolecnyDelitel
{
    internal class Vypocty
    {
        //Euklidův algoritmus pro výpočet největšího společného dělitele
        public static int Euklid(int a, int b)
        {
            int c;
            while (b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }
            return a;
        }
    }
}
