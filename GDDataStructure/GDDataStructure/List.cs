using System;
using System.Collections.Generic;
using System.Text;

namespace GDDataStructure
{
    class GDList<T>
    {
        private Node<T> head;
        private Node<T> end;
        private int count;
        public int Count
        {
            get { return count; }
        }

        public GDList()
        {

            head = new Node<T>(default(T));
            end = head;
            
            count = 0;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            end.next = node;
            end = node;
            count++;
        }

        public void Find(T t)
        {

        }

        //public T this[int index]
        //{
        //    get
        //    {
        //        if (index < count)
        //           // return array[index];
        //        return default(T);
        //    }
        //    set
        //    {
        //        if (index < count)
        //          //  array[index] = value;
        //    }
        //}


    }
    public class Node<T>
    {
        public Node<T> next;
        public T data;
      
        public Node(T t)
        {
            data = t;
        }

    }
}
