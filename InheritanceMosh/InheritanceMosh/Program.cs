using System;
using System.Collections;
using System.Collections.Generic;

namespace InheritanceMosh
{
    public class Stack
    {
        private readonly ArrayList _list = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }
            _list.Add(obj);
        }
        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException();
            }

            int index = _list.Count - 1;
            var removedObject = _list[index];
            _list.RemoveAt(index);
            return removedObject;

        }

        public void Clear()
        {
            _list.Clear();
        }

    }
    public class StackGeneric<T>
    {
        private readonly List<T> _list = new List<T>();

        public void Push(T obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }
            _list.Add(obj);
        }
        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException();
            }

            int index = _list.Count - 1;
            var removedObject = _list[index];
            _list.RemoveAt(index);
            return removedObject;

        }

        public void Clear()
        {
            _list.Clear();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());



            StackGeneric<string> stackGeneric = new StackGeneric<string>(); 
            stackGeneric.Push("Tim");
            stackGeneric.Push("Mark");
            stackGeneric.Push("Jane");


            Console.WriteLine(stackGeneric.Pop());
            Console.WriteLine(stackGeneric.Pop());
            Console.WriteLine(stackGeneric.Pop());

            Console.ReadLine();
        }
    }
}
