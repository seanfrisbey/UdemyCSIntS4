﻿using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(null);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();
        }
    }
}
