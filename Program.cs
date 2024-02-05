using System;
using System.Collections.Generic;

class GFG
{

    static public void Main()
    {

        
        Dictionary<int, string> dict = new Dictionary<int, string>();

       
        dict.Add(1, "sunil");
        dict.Add(2, "kumar");
        dict.Add(3, "nallam");
        Console.WriteLine("Elements after adding:");

       
        foreach (KeyValuePair<int, string> str in dict)
        {
            Console.WriteLine($"{ str.Key}, {str.Value}");
        }

        int trytosearch = 3;
        string value;
         
        dict.Remove(1);

        Console.WriteLine("Elements after remove:");
        foreach (KeyValuePair<int, string> str in dict)
        {
            Console.WriteLine($"{str.Key}, {str.Value}");
        }
        dict[2] = "Kumar";
        Console.WriteLine("Elements after changing value:");
        foreach (KeyValuePair<int, string> str in dict)
        {
            Console.WriteLine($"{str.Key}, {str.Value}");
        }
        Console.WriteLine(dict.ContainsKey(2));
        Console.WriteLine(dict.ContainsValue("nallam"));
        
        dict.TryGetValue(3,out value);
        Console.WriteLine(value);
        

        
        dict.Clear();

        Console.WriteLine("Total number of key/value= " + dict.Count);
        Console.ReadLine();

    }
}
