﻿using System;
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
        [TestMethod]
    }
}
