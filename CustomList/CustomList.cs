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
        public int Count { get; }
        private int Capacity { get; set; }
        T[] items = new T[4];

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
