using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2
{
    internal class Bai1b
    {
        public static void GetDetail(dynamic valua)
        {
            Console.WriteLine("Valua:" + valua);
        }
        public static void bai1b()
        {
            GetDetail(10);
            GetDetail("game");
            GetDetail(true);
            GetDetail(9.5);
        }
    }
}
