using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(8);
            list.Add(78);
            list.Add(34);
            list.Add(56);
            list.Add(34);
            list.Add(32);
            list.Reverse();
            int sum = 0;
            
            for(int i=0;i<list.Count;i++)
            {
                sum = sum + list[i];
            }
            Console.WriteLine(sum);

           
        }
    }
}
