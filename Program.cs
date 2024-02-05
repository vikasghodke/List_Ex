using System.Collections.Generic;
class ListEx_3
{

    //Find minimum and maximum numbers in List
    public static void Main(String[] args)
    {
        List<int> list = new List<int>();

        list.Add(34);
        list.Add(45);
        list.Add(56);    
        list.Add(67);
            
        list.Add(78);
            
        list.Add(609);
            
        list.Add(54);
        list.Add(88);
        list.Add(45);
        list.Add(56);
        list.Add(09);
        int max = list[0];
        int min = list[0];

        foreach(int i in list)
        {
            if(i> max)
            {
                max = i;
            }
            if (i < min)
            {
                min = i;
            }
            
        }
        Console.WriteLine("Maximum value:"+max);
        Console.WriteLine("Minimum Value:"+ min);

    }
}