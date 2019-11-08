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
        public void CustomList_Override_CharToString()
        {
            //arrange
            CustomList<char> list1 = new CustomList<char>();
            string expected = "hello";
            string actual;

            char char1 = 'h';
            char char2 = 'e';
            char char3 = 'l';
            char char4 = 'l';
            char char5 = 'o';

            //act
            list1.Add(char1);
            list1.Add(char2);
            list1.Add(char3);
            list1.Add(char4);
            list1.Add(char5);


            actual = list1.ToString();

            //assert
           Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void CustomList_Override_IntToString()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            string expected = "8";
            string actual;

            int int8 = 8;

            //act
            list1.Add(8);

            actual = list1.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void CustomList_Override_BoolToString()
        {
            //arrange
            CustomList<bool> list1 = new CustomList<bool>();
            string expected = "False";
            string actual;

            bool falseBool = false;

            //act
            list1.Add(falseBool);

            actual = list1.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        /////// OVERLOADING + OPERATOR METHOD TESTS ///////

        [TestMethod]
        public void CustomList_Add_AddTwoListsIntsTogether()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            string expected = "123456";

            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 4;
            int int5 = 5;
            int int6 = 6;

            //act
            list1.Add(int1);
            list1.Add(int2);
            list1.Add(int3);
            list2.Add(int4);
            list2.Add(int5);
            list2.Add(int6);

            CustomList<int> actual = (list1 + list2);

            //assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomList_Add_AddTwoListsCharsTogether()
        {
            //arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();
            string expected = "flamingo";

            char char1 = 'f';
            char char2 = 'l';
            char char3 = 'a';
            char char4 = 'm';
            char char5 = 'i';
            char char6 = 'n';
            char char7 = 'g';
            char char8 = 'o';

            //act
            list1.Add(char1);
            list1.Add(char2);
            list1.Add(char3);
            list1.Add(char4);
            list2.Add(char5);
            list2.Add(char6);
            list2.Add(char7);
            list2.Add(char8);

            CustomList<char> actual = (list1 + list2);

            //assert
            Assert.AreEqual(expected, actual.ToString());
        }

        ////// MINUS OPERATOR TEST METHODS //////

        [TestMethod]
        public void CustomList_Subtract_SubtractTwoListsIntsTogether()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            string expected = "1";

            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 2;
            int int5 = 2;
            int int6 = 3;

            //act
            list1.Add(int1);
            list1.Add(int2);
            list1.Add(int3);
            list2.Add(int4);
            list2.Add(int5);
            list2.Add(int6);

            CustomList<int> actual = (list1 - list2);

            //assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomList_Subtract_SubtrctTwoListsIntsTogetherReturnTwoNumbers()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            string expected = "12";

            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 4;
            int int5 = 4;
            int int6 = 3;

            //act
            list1.Add(int1);
            list1.Add(int2);
            list1.Add(int3);
            list2.Add(int4);
            list2.Add(int5);
            list2.Add(int6);

            CustomList<int> actual = (list1 - list2);

            //assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void CustomList_Subtract_SubtrctTwoListsIntsTogetherReturnThreeNumbers()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            string expected = "234";

            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            int int4 = 4;
            int int5 = 5;
            int int6 = 1;
            int int7 = 1;
            int int8 = 7;

            //act
            list1.Add(int1);
            list1.Add(int2);
            list1.Add(int3);
            list1.Add(int4);
            list2.Add(int5);
            list2.Add(int6);
            list2.Add(int7);
            list2.Add(int8);

            CustomList<int> actual = (list1 - list2);

            //assert
            Assert.AreEqual(expected, actual.ToString());
        }

        ////// ZIP METHOD UNIT TESTS ///////
        [TestMethod]

        public void CustomList_Zip_ZipperInTwoListsWithTwoItemsEach()
        {
            //arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();
            CustomList<char> expected = new CustomList<char>() {'p','o','o','p'};
            
            char char1 = 'p';
            char char2 = 'o';
            char char3 = 'o';
            char char4 = 'p';

            //act
            list1.Add(char1);
            list2.Add(char2);
            list1.Add(char3);
            list2.Add(char4);

            CustomList<char> actual = list1.Zip(list2);

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }
        [TestMethod]
        public void CustomList_Zip_ZipperInTwoListsWithDifferentCounts()
        {
            //arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();
            CustomList<char> expected = new CustomList<char>() { 'p', 'o', 'o', 'p', 'y'};

            char char1 = 'p';
            char char2 = 'o';
            char char3 = 'o';
            char char4 = 'p';
            char char5 = 'y';

            //act
            list1.Add(char1);
            list2.Add(char2);
            list1.Add(char3);
            list2.Add(char4);
            list1.Add(char5);

            CustomList<char> actual = list1.Zip(list2);

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }
    }
}



