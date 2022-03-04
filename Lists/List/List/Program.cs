using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] ar= {0,1,2,3,4,5,6,7,8,9,10};
            List list = new List(ar);
            list.Print();

        }
    }
}
