using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public class City
        {
            public int cityPincode { get; set; } 
             public string cityName { get; set; }   
        }
        static void Main(string[] args)
        {
            City city1 = new City()
            {
                cityPincode = 411027,
                cityName = "Old Sangavi"
            };
            City city2 = new City()
            {
                cityPincode = 414505,
                cityName = "Pathardi"
            };
            City city3 = new City()
            {
                cityPincode = 414106,
                cityName = "akole"
            };
            City city4 = new City()
            {
                cityPincode = 414101,
                cityName = "Mumbai"
            };

            List<City> cities = new List<City>();
            cities.Add(city1);
            cities.Add(city2);
            cities.Add(city3);

            Console.WriteLine("City List Element :-");
            foreach (City st in cities)
            {
                Console.WriteLine("City Pincode:{0}, City Name:{1}", st.cityPincode, st.cityName);
            }
            //print the count of list
            Console.WriteLine("Size of List= " + cities.Count);
            //Removing  element at the 1st index of List
            Console.WriteLine("Removing  element at 1st Index of List");
            //cities.RemoveAt(1);
            //Console.WriteLine(" updated List: ");
            //for (int i = 0; i < cities.Count; i++)
            //{
            //    Console.WriteLine(cities[i] + " ");
            //}
            //Printing the current capacity of a List
            Console.WriteLine("Current capacity of list :- " + cities.Capacity);
            cities.Insert(cities.Count, city4);
            foreach (City st in cities)
            {
                Console.WriteLine("City Pincode:{0}, City Name:{1}", st.cityPincode, st.cityName);

            }
            Console.WriteLine("--*****---Stack---******---");
            Stack<int> stackitem = new Stack<int>();
            stackitem.Push(90);
            stackitem.Push(80);
            stackitem.Push(70);
            // int is not a Reference type so null can not be accepted by this stack
            //stackitem.Push(null); //Compile-Time Error - cannot convert from <null> to int in generic collection
            Console.WriteLine("Generic stack elements:-");
            foreach (int stackElement in stackitem)
            {
                Console.WriteLine(stackElement);
            }
            Console.WriteLine("Number of elements in Stack: {0}", stackitem.Count);
            stackitem.Contains(2); // it returns boolean value
            stackitem.Pop();
            Console.WriteLine("Stack after Pop() operation:-");
            foreach (var stackItem in stackitem)
            {
                Console.WriteLine(stackItem);
            }
            Console.WriteLine("Element at top is {0}", stackitem.Peek());
            Console.WriteLine("--*****---Queue---******---");
            Queue<int> queueList = new Queue<int>();
            queueList.Enqueue(200);
            queueList.Enqueue(300);
            queueList.Enqueue(100);
            queueList.Enqueue(800);
            queueList.Enqueue(766);
            Console.WriteLine("The elements of Queue : ");
            foreach (int queueElement in queueList)
                Console.WriteLine(queueElement);
            //Dequeue() method to remove the front element of the Queue<int>
            Console.WriteLine("Remove the front element : " + queueList.Dequeue());
            Console.WriteLine("Remove the next front element : " + queueList.Dequeue());
            //Calling the Peek() method which only gets the front element of the Queue<int>, without removing it
            Console.WriteLine("Peek at the current front element : " + queueList.Peek());
            Console.WriteLine("Updated contents of Queue: ");
            foreach (int queueElement in queueList)
            {
                Console.WriteLine(queueElement);
            }
            Console.WriteLine(queueList.Contains(3));  // returns Boolean value

            Console.WriteLine("--*****---Dictionary---******---");
            Dictionary<int, string> dictList = new Dictionary<int, string>();
            //Adding key-value pairs by the Add() method
            dictList.Add(1, "Marathi");
            dictList.Add(2, "Hindi");
            dictList.Add(3, "English");
            dictList.Add(4, "Math");
            dictList.Add(90, null);
            dictList.Add(10, "History");
            //Getting a collection of the keys using property Keys
            ICollection<int> dictElement = dictList.Keys;

            // Use the keys to obtain the values.
            foreach (int dictItem in dictElement)
                Console.WriteLine(dictItem + ": " + dictList[dictItem]);

            // the property Item to retrieve the value of key 02
            //the property Item is not used with its name
            Console.WriteLine("Value at the key, 2 is " + dictList[02]);

            Console.WriteLine("Dictionary contains the value,Math: " + dictList.ContainsValue("Math"));
            // ContainsKey() to check for an unknown key
            if (dictList.ContainsKey(10))
            {
                Console.WriteLine(dictList[10]);
            }
            else
            {
                Console.WriteLine("Key Not Found");
            }
            dictList.Remove(02);
            Console.WriteLine("updated contents of Dictionary after removing keys 2 their values:");
            foreach (int keyes in dictElement)
            {
                Console.WriteLine(keyes + ": " + dictList[keyes]);
            }

            //Dictionary<String, String> dict = new Dictionary<String, String>();
            //dict.Add(null, "no value"); //Trying to store a null as a key Unhandled Exception: System.ArgumentNullException: Value cannot be null.

            Console.WriteLine("--*****---SortedList---******---");
            SortedList<String, int> listItem = new SortedList<String, int>();
            listItem.Add("Tathe", 49);
            listItem.Add("Bhagat", 2);
            listItem.Add("Thakur", 44);
            listItem.Add("Avtade", 1);
            listItem.Add("chothe", 3);

            ICollection<String> sotedItem = listItem.Keys;
            Console.WriteLine("sorted key-value pairs of SortedList:");
            foreach (String sortedListKey in sotedItem)
            {
                Console.WriteLine(sortedListKey + ": " + listItem[sortedListKey]);
            }
            //Getting the index of the key 'Bhagat'
            //where, the first key is stored at zero-index position
            Console.WriteLine("Index of key Bhagat: " + listItem.IndexOfKey("Bhagat"));

            Console.WriteLine("Index of value 44: " + listItem.IndexOfValue(44));
        }
    }
}
