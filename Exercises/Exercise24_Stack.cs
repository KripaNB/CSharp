using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise24
{
    public class Stack
    {
        private List<object> _items = new List<object>();
        public void Push (object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null value cannot be passed to the stack.");
            _items.Add(obj);
        }

        public object Pop()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("The stack is empty.");
            var last = _items.Last();
            _items.Remove(last);
            return last;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}
