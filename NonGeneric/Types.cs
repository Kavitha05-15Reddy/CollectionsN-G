using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric
{
    class Types
    {
        public void ArrayLists()
        {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add(2.3);
            a.Add('A');
            a.Add("Hello");
            a.Add(null);
            Console.WriteLine("Added elements");
            foreach (var i in a)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("after inserted elements");
            a.Insert(0, 10);
            a.Insert(3, "hai");
            foreach (var i in a)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("after removing elements");
            a.Remove(2.3);
            a.RemoveAt(1);
            foreach (var i in a)
            {
                Console.WriteLine(i + " ");
            }

        }
        public void HashTables()
        {
            Hashtable h = new Hashtable();
            h.Add("id",01);
            h.Add("name","Sri");
            h.Add("age", 25);
            h.Add("phno", 7876467892);
            h.Add("tech", ".net");
            h.Add("role","developer");
            Console.WriteLine(h["id"]);
            Console.WriteLine("hello".GetHashCode());
            foreach (var key in h.Keys)
            {
                //Console.WriteLine(key);
                Console.WriteLine(key + ":" + h[key]);
            }
            foreach (DictionaryEntry d in h)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }
        }
        public void SortedLists()
        {
            SortedList l = new SortedList();
            l.Add("greet","hello");
            l.Add("send","bye");
            l.Add("good","morning");
            l.Add("after","noon");
            foreach (DictionaryEntry d in l)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }
        }
        public void Stacks()
        {
            Stack s = new Stack(); 
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            s.Push(50);
            Console.WriteLine("pushed elements:");
            foreach(var i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("peek element:");
            Console.WriteLine(s.Peek());
            s.Pop();
            s.Pop();
            Console.WriteLine("after popped elements:");
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
        }
        public void Queues()
        {
            Queue q = new Queue();
            q.Enqueue("hello");
            q.Enqueue("hai");
            q.Enqueue("hru");
            q.Enqueue("bye");
            Console.WriteLine("inserted elements:");
            foreach (var i in q)
            {
                Console.WriteLine(i);
            }
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine("after deleted elements:");
            foreach (var i in q)
            {
                Console.WriteLine(i);
            }
        }
    }
}
