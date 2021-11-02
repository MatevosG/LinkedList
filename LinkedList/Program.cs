using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();
            singleLinkedList.InsertFront(1);
            singleLinkedList.InsertFront(2);
            singleLinkedList.InsertFront(3);
            singleLinkedList.InsertLast(4);
            var someNode = singleLinkedList.head._next;
            singleLinkedList.InsertAfter(someNode, 10);
            singleLinkedList.DeleteNodeByKey(3);
            singleLinkedList.ReverseLinkedList();

            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.InsertFront(1);
            doubleLinkedList.InsertFront(2);
            doubleLinkedList.InsertFront(3);
            doubleLinkedList.InsertLast(4);
            var somedNode = doubleLinkedList.head._next;
            doubleLinkedList.InsertAfter(somedNode, 10);
            doubleLinkedList.DeleteNodeByKey(1);
            doubleLinkedList.Reverse();
        }
    }
}
