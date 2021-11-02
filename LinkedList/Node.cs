using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node <T>
    {
        internal  T _data;
        internal Node <T> _next;
        public Node(T data)
        {
            _data = data;
            _next = null;
        }
    }
}
