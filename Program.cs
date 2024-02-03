using System;
using System.Collections;


namespace Collection_Framework
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("sunil");
            queue.Enqueue(3);
            queue.Enqueue("kumar");
            queue.Enqueue("nallam");
            Console.WriteLine("The elements present after enqueue: ");
            foreach (var item in queue)
            {      
                Console.WriteLine(item);
            }
            queue.Dequeue();
            Console.WriteLine("The elements present after dequeue: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Peek();
            Console.WriteLine("The elements present after peek is : {0} ",queue.Peek());
           if(queue.Contains("sunil") == true)
            {
                Console.WriteLine("Element available in the queue");
            }
            
            queue.Clear();
            Console.WriteLine("The elements present  after clear: {0} ",queue.Count);
            
            Console.ReadLine();
        }
    }
}
