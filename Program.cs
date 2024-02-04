using System;
using System.Collections.Generic;

class GFG
{
    static public void Main()
    { 
        HashSet<String> list = new HashSet<String>();

        list.Add("sunil");
        list.Add("jash");
        list.Add("rohith");
        list.Add("anand");
        list.Add("shridhar");
        list.Add("pradeep");
        Console.WriteLine("Elements after adding:");
        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
        HashSet<String> set = new HashSet<String>();
        set.Add("sunil");
        set.Add("anil");
        set.Add("mallikarjuna");
        set.Add("rohith");
        Console.WriteLine("Elements after adding:");
        foreach (string str in set)
        {
            Console.WriteLine(str);
        }
        list.IntersectWith(set);
        Console.WriteLine("total elements after intersectwith:");
        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
        list.ExceptWith(set);
        Console.WriteLine("elements after exceptwith:");
        foreach (string str in set)
        {
            Console.WriteLine(str);
        }
        list.UnionWith(set);
        Console.WriteLine("total elements after unionwith:");
        foreach(string str in list)
        {
            Console.WriteLine(str);
        }
        

        list.Remove("mallikarjuna");
        Console.WriteLine("Elements after remove:");

        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
        list.Clear();
        Console.WriteLine("Number of elements: "+ list.Count);
        Console.ReadLine();
    }
}
