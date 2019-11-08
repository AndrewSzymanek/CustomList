using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        //member variables
        T[] items;
        private int count;
        public int Count
        {
            get
            { return count; }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public T this[int index]
        {
            get { return items[index]; }
        }

        //constructor
        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
        }

        //member methods

        public void Add(T item)
        {
            if (count == capacity)
            {
                Resize();
            }
            items[count] = item;
            count++;
        }
        public void Resize()
        {
            capacity *= 2;
            T[] newArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }
        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    count--;
                    if (count == 0)
                    {
                        items = new T[capacity];
                    }
                    else
                    {
                        for (int j = i + 1; j <= count; j++)
                        {
                            items[j - 1] = items[j];
                        }
                    }
                }
            }
        }
        public override string ToString()
        {
            string listString = "";
            for(int i = 0; i < count; i++)
            {
                listString += (items[i].ToString());
            }
            return listString;
        }

        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {             
                newList.Add(list1[i]);               
            }
            for (int i = 0; i < list2.Count; i++)
            {               
                newList.Add(list2[i]);                
            }        
            return newList;
        }
        public static CustomList<T> operator - (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            for(int i = 0; i < list1.Count; i++)
            {
                bool isEqual = false;
               for(int j = 0; j < list2.Count; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        isEqual = true;
                    }
                    else if(j == (list2.Count - 1) && isEqual == false)
                    {
                        newList.Add(list1[i]);
                    }
                }              
            }                
            return newList;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }
    }
}
