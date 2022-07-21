using System;
using System.Collections;

namespace StackAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4.4);
            st.Push('c');
            st.Push("Nitin");
            Console.WriteLine("Stack Elements are:-");
            foreach (var stackItem in st)
            {
                Console.WriteLine(stackItem);
            }
            st.Pop();
            st.Pop();
            Console.WriteLine("Stack after Pop() operation:-");
            foreach (var stackItem in st)
            {
                Console.WriteLine(stackItem);
            }
            Console.WriteLine("Element at top is {0}", st.Peek());

            // Checking whether the element is present in the Stack or not
            Console.WriteLine(st.Contains("Nitin")); // The function returns boolean value

            Stack clstack = st;
            foreach (var item in clstack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------Queue-----------");
            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);
            qt.Enqueue(4);
            qt.Enqueue(5);
            Console.WriteLine("Queue elements are:");
            foreach (int item in qt)
            {
                Console.WriteLine(item + " ");
            }
            qt.Dequeue();
            Console.WriteLine("Queue after Dequeue() operation: ");
            foreach (int item in qt)
            {

                Console.WriteLine(item + " ");
            }
            Console.WriteLine("Element at the start of the queue is: {0}", qt.Peek());

            // Checking whether the element is present in the Queue or not
            Console.WriteLine(qt.Contains(3));  // returns Boolean value

            // Removing all elements from Queue
            //qt.Clear();

            Hashtable my_hashtable = new Hashtable();
            my_hashtable.Add("c1", "Mumbai");
            my_hashtable.Add("c2", "Pune");
            my_hashtable.Add("c3", "Nagar");
            my_hashtable.Add("c4", "Kolhapur");
            my_hashtable.Add("pin1", 414505);

            //foreach (var tableItem in my_hashtable.Keys)
            //{
            //    Console.WriteLine(tableItem + " : " + my_hashtable[tableItem]);
            //}
            //using Dictionary print values of hashatable
            foreach (DictionaryEntry entry in my_hashtable)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }

            my_hashtable.Remove("c3");
            Console.WriteLine("after remove operation:");
            foreach (DictionaryEntry entry in my_hashtable)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
            // Clear the Hashtable.
            my_hashtable.Clear();

            // Get Count of Hashtable again.
            Console.WriteLine(my_hashtable.Count);

        }
       
    }
}
