using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DoubleLinkedList<T>
    {
        internal DNode<T> head;
        internal void InsertFront(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            newNode._next = head;
            newNode._prev = null;
            if (head != null)
            {
                head._prev = newNode;
            }
            head = newNode;
        }
        internal void InsertLast( T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            if (head == null)
            {
                newNode._prev = null;
                head = newNode;
                return;
            }
            DNode<T> lastNode = GetLastNode();
            lastNode._next = newNode;
            newNode._prev = lastNode;
        }
        internal DNode<T> GetLastNode()
        {
            DNode<T> temp =head;
            while (temp._next != null)
            {
                temp = temp._next;
            }
            return temp;
        }
        internal void InsertAfter(DNode<T> prev_node, T data)
        {
            if (prev_node == null)
            {
                throw new ArgumentNullException("The given prevoius node cannot be null");

            }
            DNode<T> newNode = new DNode<T>(data);
            newNode._next = prev_node._next;
            prev_node._next = newNode;
            newNode._prev = prev_node;
            if (newNode._next != null)
            {
                newNode._next._prev = newNode;
            }
        }
        public void DeleteNodeByKey(T key)
        {
            DNode<T> temp = head;
            if (temp != null && Equals(temp._data, key))
            {
                head = temp._next;
                head._prev = null;
                return;
            }
            while (temp != null && !Equals(temp._data, key))
            {
                temp = temp._next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp._next != null)
            {
                temp._next._prev = temp._prev;
            }
            if (temp._prev != null)
            {
                temp._prev._next = temp._next;
            }
        }
       public void Reverse()
        {
            DNode<T> temp = null;
            DNode<T> current = head;
            while (current != null)
            {
                temp = current._prev;
                current._prev = current._next;
                current._next = temp;
                current = current._prev;
            }
            if (temp != null)
            {
                head = temp._prev;
            }
        }
    }
}
