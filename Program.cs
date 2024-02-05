using System;
using System.Collections.Generic;

class GFG
{
    static public void Main()
    { 
        SortedSet<String> list = new SortedSet<String>();

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
        SortedSet<String> set = new SortedSet<String>();
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
        var condition = list.RemoveWhere(word => word.StartsWith("s", StringComparison.OrdinalIgnoreCase));
        var condition1 = list.RemoveWhere(word => word.StartsWith("m", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Elements after removewhere:");

        foreach (var word in list)
        {
            Console.WriteLine(word);
        }



        list.Remove("rohith");
        Console.WriteLine("Elements after remove:");

        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
        list.Clear();
        Console.WriteLine("Number of elements after clear: "+ list.Count);
        Console.ReadLine();
    }
}
