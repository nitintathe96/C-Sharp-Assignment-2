using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Stack--------");
            Stack<int> stackitem = new Stack<int>();
            stackitem.Push(90);
            stackitem.Push(80);
            stackitem.Push(70);
            //As int is not a Reference type so null can not be accepted by this stack
            //stackitem.Push(null); //Compile-Time Error - cannot convert from <null> to int in generic collection
            Console.WriteLine("Generic stack elements:-");
        }
    }
}   
