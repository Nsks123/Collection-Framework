using System;
using System.Collections;


namespace Collection_Framework
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("sunil");
            stack.Push(2);
            stack.Push("kumar");
            stack.Push(3);
            stack.Push("nallam");
            Console.WriteLine("The elements present after push: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            Console.WriteLine("The elements present after pop: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Peek();
            Console.WriteLine("The elements present after peek is : {0} ", stack.Peek());
            if (stack.Contains("sunil") == true)
            {
                Console.WriteLine("true");
            }

            stack.Clear();
            Console.WriteLine("The elements present  after clear: {0} ", stack.Count);

            Console.ReadLine();
        }
    }
}