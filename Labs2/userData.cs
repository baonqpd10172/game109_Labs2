using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2
{
    public class userData
    {
        public string id, userName;
        public int lever;
        public userData()
        {
            id = "0";
            lever = 0;
            userName = "null";
        }
        public userData(string id, string userName, int lever)
        {
            this.id = id;
            this.userName = userName;
            this.lever = lever;
        }
        public void Xuat()
        {
            Console.WriteLine("Id:" + id);
            Console.WriteLine("UserName: " + userName);
            Console.WriteLine("lever: "+ lever);
        }
    }
}
