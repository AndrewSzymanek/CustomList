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
            get { return items[index];}
        }

        //constructor
        //CustomList<int> list1 = new CustomList<int>();
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
            //change the order of things so items doesn't get wiped out down here
            //how to keep adding items?
            //for loop?
            //how do we know when to stop?
        }
        public void Resize()
        {
                
            if (count == capacity)
            {
                capacity *= 2;
                T[] newArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
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
