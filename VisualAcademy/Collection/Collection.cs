using System;
using System.Collections;   // rarely used these days

class Collection
{
    static void Main()
    {
        // [Collection]
        // array, list, dictionary            
        // Array, Stack, Queue, ArrayList, Hashtable

        // Array
        System.Console.WriteLine("[Array]");
        string[] colors = {"red", "green", "blue"};
        System.Console.WriteLine($"{colors[0]},{colors[1]},{colors[2]}");
        Array.Sort(colors);
        System.Console.WriteLine($"{colors[0]},{colors[1]},{colors[2]}");
        Array.Reverse(colors);
        System.Console.WriteLine($"{colors[0]},{colors[1]},{colors[2]}");

        // Stack(LIFO)
        System.Console.WriteLine("[Stack]");
        Stack stack = new Stack();
        stack.Push(100);
        stack.Push(200);
        System.Console.WriteLine(stack.Pop());
        System.Console.WriteLine(stack.Pop());

        // Queue(FIFO)
        System.Console.WriteLine("[Queue]");
        Queue queue = new Queue();
        queue.Enqueue(100);
        queue.Enqueue(200);
        System.Console.WriteLine(queue.Dequeue());
        System.Console.WriteLine(queue.Dequeue());
        
        // ArrayList
        System.Console.WriteLine("[ArrayList]");
        ArrayList list = new ArrayList();
        list.Add(100);
        list.Add(100);
        System.Console.WriteLine($"{list[0]}, {list[1]}");
        list.RemoveAt(1);
        list.Add(200);
        System.Console.WriteLine($"{list[0]}, {list[1]}");
        list.Insert(0, 50);
        System.Console.WriteLine($"{list[0]}, {list[1]}, {list[2]}");

        // Hashtable
        System.Console.WriteLine("[Hashtable]");
        Hashtable hashtable = new Hashtable();
        hashtable[0] = "KOR";
        hashtable["Nickname"] = "ToBeNew";
        System.Console.WriteLine($"{hashtable[0]}, {hashtable["Nickname"]}");
    }
}