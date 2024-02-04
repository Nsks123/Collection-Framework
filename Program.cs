using System;
using System.Collections.Generic;




namespace Collection_Framework
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list= new List<string>();
            list.Add("ramesh");
            list.Add("hyma");
            list.Add("mahesh");
            list.Add("sai");
            list.Add("sunil");
            list.Add("nallam");
            Console.WriteLine("The elements present after adding: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove("sunil");
            Console.WriteLine("elements present after remove: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("capacity of the list is "+list.Capacity);
            list.RemoveAt(1);
            Console.WriteLine("elements present after removeat: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.RemoveRange(1, 2);
            Console.WriteLine("elements present after removerange: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            list.RemoveAll(word => word.StartsWith("r", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("elements present after removeall: ");
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Clear();
            Console.WriteLine("no.of items present in the list after clear: " + list.Count);


            Console.ReadLine();
        }
    }
}
