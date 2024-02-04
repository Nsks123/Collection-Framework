using System;
using System.Collections.Generic;

class GFG
{
    static public void Main()
    { 
        LinkedList<String> list = new LinkedList<String>();

        list.AddLast("Sunil");
        list.AddFirst("jash");
        list.AddLast("Rohit");
        list.AddFirst("anand");
        list.AddFirst("shridhar");
        list.AddLast("pradeep");

        Console.WriteLine("Elements after adding:");
        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
        list.Remove(list.Last);
        Console.WriteLine("Elements after removelast:");

        foreach (string str in list)
        {
            Console.WriteLine(str);
        }

        list.Remove("Rohit");
        Console.WriteLine("Elements after remove value:");

        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
        

        list.RemoveFirst();
        Console.WriteLine("Elements after removefirst:");

        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine(list.Contains("sunil")==true);
        ;
        list.Clear();
        Console.WriteLine("Number of students: "+ list.Count);
        Console.ReadLine();
    }
}
