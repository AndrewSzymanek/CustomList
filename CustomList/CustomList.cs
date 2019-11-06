using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> 
    {
        //member variables
        
        private int count;
        public int Count
        {
            get
            { return count; }
        }
        private int capacity = 4;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if(count == capacity)
                {
                    capacity = (capacity * 2);
                }
            }
        }

        //constructor
        //CustomList<int> list1 = new CustomList<int>();


        //member methods
        public void Add(T item)
        {
            T[] items = new T[capacity];
            for (int i = 0; i <= capacity; i++)
            {
                items[i] = item;
            }
           
            count++;
            //how to keep adding items?
            //for loop?
            //how do we know when to stop?
        }
        public void Resize()
        {
            if (count == capacity)
            {
                capacity *= 2;
            }
        }
        //public void KeepCount()
        //{

        //}
        //public void DisplayCapacity()
        //{

        //}

        //add method

        //call the resize method in the add(probably also have a method that tracks that count/capacity)?

    }
}
