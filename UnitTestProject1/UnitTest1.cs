using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //////// ADD TEST METHODS ////////
       
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
        public void CustomList_Add_CheckIndexValue()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int number1 = 40;
            int number2 = 60;
            int number3 = 80;
            int number4 = 100;

            int expected = 80;
            int actual;

            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            actual = list1[2];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_Add_CheckingCapacityResizing()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 8;
            int actual;
            int number1 = 5;
            int number2 = 5;
            int number3 = 5;
            int number4 = 5;
            int number5 = 5;

            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            actual = list1.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Add_CountAfterAddedCapacity()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 5;
            int actual;
            int number1 = 5;
            int number2 = 5;
            int number3 = 5;
            int number4 = 5;
            int number5 = 5;

            //act
            list1.Add(number1);
            list1.Add(number2);
            list1.Add(number3);
            list1.Add(number4);
            list1.Add(number5);
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_Add_CheckBoolFalseOrNot()
        {
            //arrange
            CustomList<bool> list1 = new CustomList<bool>();
            bool expected = false;
            bool actual;
            bool bool1 = false;

            //act
            list1.Add(bool1);
            actual = list1[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_Add_MakeMultipleStringsIntoOne()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected = "HelloWorld";
            string actual;
            string string1 = "Hello";
            string string2 = "World";

            //act
            list1.Add(string1);
            list1.Add(string2);
            actual = (list1[0] + list1[1]);

            //assert
            Assert.AreEqual(expected, actual);
            //good for overloaded plus operator!
        }
        ///////// REMOVE TEST METHODS //////////
        
        [TestMethod]
        public void CustomList_Remove_CheckCountAfterRemovingOneItem()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            int expected = 3;
            int actual;
            string string1 = "hi";
            string string2 = "hello";
            string string3 = "what up";
            string string4 = "shalom";
            
            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            list1.Add(string4);
            list1.Remove("what up");
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_Remove_CheckCountAfterRemovingTwoItems()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            int expected = 2;
            int actual;
            string string1 = "hi";
            string string2 = "hello";
            string string3 = "what up";
            string string4 = "shalom";

            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            list1.Add(string4);
            list1.Remove(list1[2]);
            list1.Remove(list1[2]);
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void CustomList_Remove_CheckCapacityAfterRemovingTwoItems()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int expected = 4;
        //    int actual;
        //    int number1 = 5;
        //    int number2 = 5;
        //    int number3 = 5;
        //    int number4 = 5;
        //    int number5 = 5;

        //    //act
        //    list1.Add(number1);
        //    list1.Add(number2);
        //    list1.Add(number3);
        //    list1.Add(number4);
        //    list1.Add(number5);
        //    list1.Remove(list1[2]);
        //    list1.Remove(list1[3]);
        //    actual = list1.Capacity;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void CustomList_Remove_CheckIndexValueCorrectAfterRemovingAnIndex()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected = "what up";
            string actual;
            string string1 = "hi";
            string string2 = "hello";
            string string3 = "what up";
            string string4 = "shalom";

            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            list1.Add(string4);
            list1.Remove("hello");
            actual = list1[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustomList_Remove_CheckIndexValueCorrectAfterRemovingTwoIndeces()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected = "what up";
            string actual;
            string string1 = "hi";
            string string2 = "hello";
            string string3 = "what up";
            string string4 = "shalom";

            //act
            list1.Add(string1);
            list1.Add(string2);
            list1.Add(string3);
            list1.Add(string4);
            list1.Remove("hi");
            list1.Remove("hello");
            actual = list1[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //////// OVERRIDING TOSTRING METHOD TESTS ////////

        [TestMethod]
        public void CustomList_Override_OverrideStringCreation()
        {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string expected;
            string actual;

          
            //act
            
            //actual =;

            //assert
           // Assert.AreEqual(expected, actual);
        }

        /////// OVERLOADING + OPERATOR METHOD TESTS ///////

        [TestMethod]
        public void CustomList_Add_AddTwoListsTogether()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> actual;
           // CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            //IEnumerable needed to access that list above
       

            //act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            actual = list1 + list2;
            //assert
          //  CollectionAssert.AreEqual(expected, actual);
           
        }
    }
}
