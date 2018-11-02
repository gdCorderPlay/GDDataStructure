using System;
using System.Collections.Generic;
using System.Text;

namespace GDDataStructure
{
    class GDListArray<T>
    {
        private int count;
        public int Count
        {
            get { return count; }
        }
        private int capacity;
        private T[] array;
        public GDListArray()
        {
            capacity = 2;
            array = new T[capacity];
        }
        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            if (count >=capacity)
            {
                capacity *= 2;
                T[] newArray = new T[capacity];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            array[count] = t;
            count++;
        }

        /// <summary>
        /// 删除遇到的第一个满足条件的元素
        /// </summary>
        public bool  Remove(T t)
        {
            
            int index = Find(t);
            bool success = index >= 0;
            //查找成功
            if (success)
            {
                for (; index < count-1; index++)
                {
                    array[index] = array[index + 1];
                }
                count--;
            }
            return success;
        }

        /// <summary>
        /// 查找
        /// </summary>
        public int Find(T t)
        {
            int index = -1;
            for(int i = 0; i < count; i++)
            {
                if (t.Equals(array[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        /// <summary>
        /// 插入
        /// </summary>
        public void Insert(T t,int index)
        {
            //超出界限
            if (index > count)
                return;
            Add(t);
            for(int i = count - 1; i > index; )
            {
                array[i] = array[i--];
            }
            array[index] = t;
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get {
                if (index < count)
                    return array[index];
                return default(T);
            }
            set {
                if(index<count)
                array[index] = value;
            }
        }

    }
    


}
