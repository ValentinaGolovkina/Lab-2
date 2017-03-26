﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
    }

    public class DoubleLinkedListTDD<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public int Count()
        {
            int count = 0;
            Node<T> current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public void add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
        }

        public Node<T> find(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return current;
                current = current.Next;
            }
            return null;
        }

        public bool remove(T data)
        {
            throw new NotImplementedException();
        }
    }
}
