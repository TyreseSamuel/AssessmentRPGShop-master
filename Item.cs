using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop3
{
    class Item
    {
        public string typeName;
        public string name;
        public string description;
        public int cost;
        //public Item(string name, string desc,int cost)
        //{
            //name =
        //}
        public void PrintItem()
        {
            Console.WriteLine(typeName);
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine(cost);
        }
    }
}
