using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DNode<T>
    {
        internal T _data;
        internal DNode<T> _prev;
        internal DNode<T> _next;
        public DNode(T data)
        {
            _data = data;
            _prev = null;
            _next = null;
        }
    }
}
