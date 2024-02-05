
using System.Collections.Generic;

class ListEx_2
{
    public static void Main(String[] args)
    {




        List<int> list = new List<int>();

        list.Add(1);

        list.Add(2);
        list.Add(89);
        list.Add(32);
        list.Add(34);
        list.Add(45);
        list.Add(56);
        list.Add(67);
        list.Add(78);
        list.Add(189);
        list.Add(19);
        list.Reverse();

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}
