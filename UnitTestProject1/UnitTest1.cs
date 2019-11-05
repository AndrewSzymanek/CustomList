using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomList_Add_AddingOneValueCount()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 1;
            int actual;
            int number1 = 5;
            

            //act
            list1.Add(number1);
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void CustomList_Add_ResizingCapacityOfArray()
        {
            if(list1.Capacity >= 4)
            {
                new CustomList<T>();
                
            }

        }
        [TestMethod]
        public void


        [TestMethod]
        public void
    }
}
