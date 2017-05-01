using System;
using System.Collections;

namespace Exercise1
{
    class Stack
    {
        private ArrayList stack = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("A null object may not be added to the stack.");

            stack.Add(obj);
        }

        public object Pop()
        {
            var lastItem = stack[stack.Count-1];
            stack.RemoveAt(stack.Count-1);
            return lastItem;
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}
