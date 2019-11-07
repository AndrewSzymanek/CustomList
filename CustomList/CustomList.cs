﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> 
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
            get {return items[index];}
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
            T[] newArray;
            for (int i = 0; i < count; i++)
            {
                if(items[i].Equals(item))
                {                       
                        count--;
                    if (count == 0)
                    {
                        items = new T[capacity];
                    }
                    else
                    {
                        newArray = new T[count];
                        for (int j = 0; j < count; j++)
                        {
                            newArray[j] = items[j];                            
                        }
                        for (int k = i + 1; k <= count; k++)
                        {
                            newArray[k - 1] = items[k];                          
                        }
                        items = newArray;
                    }
                }
            }
        }
    }
}
