using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Double_Linked_List
{
    public class CustomLinkedList<T> :  ILinkedList<T> where T : IEquatable<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int count;

        public CustomLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        //ILinkedList implementation
        public void AddToFront(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                //newNode.Previous = tail;
                head = newNode;

            }
            count++;
        }

       public void AddToEnd(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                //newNode.Next = head;//the last node point's to the first
                tail = newNode;
            }
            count++;
        }

        //IEnumerable implementation
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> Current = head;
            while (Current != null)
            {
                yield return Current.Data;
                Current = Current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item) 
        {
            AddToEnd(item);
        }

        public bool IsReadOnly => false;

        public int Count => count;

        public bool Remove(T item) 
        {
            Node<T> current = head;

            Node<T> tempNode = new Node<T>(item);

            while (current != null) 
            {
                if (current.Equals(tempNode))
                {
                    if (current.Previous != null)
                    {
                        
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
                    }

                    count--;
                    return true;
                }
                current = current.Next; 
               
            }
            return false;
        }

        public bool Contains(T item) 
        {
            Node<T> current =head;

            Node<T> tempNode = new Node<T>(item);

            while (current != null) 
            {
                if (current.Equals(tempNode)) 
                {
                    return true;
                }
                current=current.Next;
            }
            return false;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void CopyTo(T[] array, int arrayIndex) 
        {
            Node<T> current = head;
            try
            {
                while (current != null)
                {
                    array[arrayIndex++] = current.Data;
                    current = current.Next;
                }

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
