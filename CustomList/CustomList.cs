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
        
        
        
        //T[] items = new T[4];

        //constructor
       


        //member methods
        public void Add(T item)
        {
            items[0] = item; 
        }
        //public void Resize()
        //{
        //    if (count == capacity)
        //    {

        //    }
        //}
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
