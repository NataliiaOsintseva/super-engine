using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class LinkedList<T>
    {
        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        public LinkedListNode<T> Tail
        {
            get;
            private set;
        }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            // Save the current head node
            LinkedListNode<T> temp = Head;

            // Assign new node as a new Head
            Head = node;

            // Insert the ex-Head
            Head.Next = temp;

            if (Count == 0)
            {
                // If the list was empty then Head and Tail are the same node
                Tail = Head;
            }
            else
            {
                // Previous of ex-head was null, now it will point to Head
                temp.Previous = Head;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;

                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }

                Count--;
            }
        }

        public int Count
        {
            get;
            private set;
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }
    }
}
