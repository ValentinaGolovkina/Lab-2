using System;
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
            return count;
        }
    }
}
