using System;
using System.Collections.Generic;

namespace EDCGadgetManager
{
    public class GadgetLinkedList
    {
        private Node head;

        public void Add(Gadget gadget)
        {
            Node newNode = new Node(gadget);
            if (head == null)
                head = newNode;
            else
            {
                Node current = head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = newNode;
            }
        }

        public bool Remove(string name)
        {
            Node current = head, previous = null;
            while (current != null)
            {
                if (current.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    if (previous == null)
                        head = current.Next;
                    else
                        previous.Next = current.Next;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public Gadget Find(string name)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return current.Data;
                current = current.Next;
            }
            return null;
        }

        public int Count()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public void InsertAt(Gadget gadget, int position)
        {
            Node newNode = new Node(gadget);
            if (position <= 0 || head == null)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }
            Node current = head;
            int index = 0;
            while (current.Next != null && index < position - 1)
            {
                current = current.Next;
                index++;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void Reverse()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public void Clear() => head = null;

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No gadgets in the list.");
                return;
            }
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void DisplayByDay(DayOfWeek day)
        {
            bool found = false;
            Node current = head;
            while (current != null)
            {
                if (current.Data.IsCarriedOn(day))
                {
                    Console.WriteLine(current.Data);
                    found = true;
                }
                current = current.Next;
            }
            if (!found)
                Console.WriteLine($"No gadgets carried on {day}.");
        }
    }

}
