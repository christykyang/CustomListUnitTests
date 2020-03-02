using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_SingleItem_ToCustomList()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            //Act
            list.AddItem(24);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }
         
        [TestMethod]
        public void AddItem_CheckIndexOfFirstItem()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 24;

            //Act
            list.AddItem(expected);

            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Add_CheckIndexOfNextItem()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int numberOne = 24;
            int numberTwo = 30;
            int expected = 30;

            //Act
            list.AddItem(numberOne);
            list.AddItem(numberTwo);

            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void AddIndexOutOrRange()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 8;

            //Act
            list.AddItem(24);
            list.AddItem(30);
            list.AddItem(2);
            list.AddItem(5);
            list.AddItem(8);

            //Assert
            Assert.AreEqual(expected, list[4]);
        }

        [TestMethod]
        public void CheckCountAfterCopy()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 5;

            //Act
            list.AddItem(24);
            list.AddItem(30);
            list.AddItem(2);
            list.AddItem(5);
            list.AddItem(8);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void CopyOriginalArray()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 24;

            //Act
            list.AddItem(24);
            list.AddItem(30);
            list.AddItem(2);
            list.AddItem(5);
            list.AddItem(8);

            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void Remove_ItemFromCustomList()
        {
            //Arrrange
            CustomList<int> list = new CustomList<int>();
            int expected = 2;
            int numberOne = 24;
            int numberTwo = 30;
            int numberThree = 2;

            //Act
            list.AddItem(numberOne);
            list.AddItem(numberTwo);
            list.AddItem(numberThree);
            list.RemoveItem(2);

            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]
        public void RemoveItemAtZero_CheckIfListShifted()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 30;
            int numberOne = 24;
            int numberTwo = 30;
            int numberThree = 2;

            //Act
            list.AddItem(numberOne);
            list.AddItem(numberTwo);
            list.AddItem(numberThree);
            list.RemoveItem(24);

            //Assert
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]
        public void RemoveItem_CheckIndexOne()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int numberOne = 24;
            int numberTwo = 30;
            int numberThree = 2;
            int expected = 2;

            //Act
            list.AddItem(numberOne);
            list.AddItem(numberTwo);
            list.AddItem(numberThree);
            list.RemoveItem(30);

            //Assert
            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void RemoveTwoItems_CheckIfIndexMoves()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 8;

            //Act
            list.AddItem(2);
            list.AddItem(30);
            list.AddItem(2);
            list.AddItem(5);
            list.AddItem(8);
            list.RemoveItem(5);

            //Assert
            Assert.AreEqual(expected, list[3]);
        }

        [TestMethod]
        public void String_OneContentInList()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "24";
            string actual;

            //Act
            list.AddItem(24);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void String_MultipleContents()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "24302";
            string actual;

            //Act
            list.AddItem(24);
            list.AddItem(30);
            list.AddItem(2);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void String_ContentsOverOriginalMaxCapacity()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "2430258";
            string actual;

            //Act
            list.AddItem(24);
            list.AddItem(30);
            list.AddItem(2);
            list.AddItem(5);
            list.AddItem(8);
            actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddOneItemFromTwoListsTogether_CheckIndex()
        {
            //Arrange
            CustomList<int> numbersList1 = new CustomList<int>();
            numbersList1.AddItem(1);

            CustomList<int> numbersList2 = new CustomList<int>();
            numbersList2.AddItem(2);

            CustomList<int> finalNumbersList = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            finalNumbersList = numbersList1 + numbersList2;
            actual = finalNumbersList[0];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddTwoLists_CheckCount()
        {
            //Arrange
            CustomList<int> numbersList1 = new CustomList<int>();
            numbersList1.AddItem(1);
            numbersList1.AddItem(2);

            CustomList<int> numbersList2 = new CustomList<int>();
            numbersList2.AddItem(3);
            numbersList2.AddItem(4);

            CustomList<int> finalNumbersList = new CustomList<int>();
            int expected = 4;

            //Act
            finalNumbersList = numbersList1 + numbersList2;

            //Assert
            Assert.AreEqual(expected, finalNumbersList.Count);
        }
        [TestMethod]
        public void AddMultipleStringsFromTwoLists()
        {
            //Arrange
            CustomList<string> stringList1 = new CustomList<string>();
            stringList1.AddItem("Hello, ");
            stringList1.AddItem("my ");
            stringList1.AddItem("name ");
            stringList1.AddItem("is ");

            CustomList<string> stringList2 = new CustomList<string>();
            stringList2.AddItem("Christy");
            stringList2.AddItem(".");

            CustomList<string> finalString = new CustomList<string>();
            string expected = "Christy";
            string actual;

            //Act
            finalString = stringList1 + stringList2;

            //Assert
            Assert.AreEqual(expected, finalString[4]);
        }
        [TestMethod]
        public void SubtractOneItemFromTwoListsTogether_CheckCount()
        {
            //Arrange
            CustomList<int> numbersList1 = new CustomList<int>();
            numbersList1.AddItem(24);
            numbersList1.AddItem(30);
            numbersList1.AddItem(2);

            CustomList<int> numbersList2 = new CustomList<int>();
            numbersList2.AddItem(1);
            numbersList2.AddItem(2);

            CustomList<int> finalNumbersList = new CustomList<int>();
            int expected = 2;

            //Act
            finalNumbersList = numbersList1 - numbersList2;

            //Assert
            Assert.AreEqual(expected, finalNumbersList.Count); 
        }
        [TestMethod]
        public void SubtractOneInt_FromListTwo()
        {
            //Arrange
            CustomList<int> numbersList1 = new CustomList<int>();
            numbersList1.AddItem(24);
            numbersList1.AddItem(30);
            numbersList1.AddItem(2);
            CustomList<int> numbersList2 = new CustomList<int>();
            numbersList2.AddItem(2);
            numbersList2.AddItem(1);

            CustomList<int> finalList = new CustomList<int>();
            int expected = 1;

            //Act
            finalList = numbersList2 - numbersList1;

            //Assert

            Assert.AreEqual(expected, finalList[0]);
        }
        [TestMethod]
        public void SubtractMultipleContents()
        {
            //Arrange
            CustomList<string> numbersList1 = new CustomList<string>();
            numbersList1.AddItem("See ");
            numbersList1.AddItem("Spot ");
            numbersList1.AddItem("run. ");
            CustomList<string> numbersList2 = new CustomList<string>();
            numbersList2.AddItem("See ");
            numbersList2.AddItem("Spot ");
            numbersList2.AddItem("dig.");
            CustomList<string> finalList = new CustomList<string>();
            int expected = 1;

            //Act
            finalList = numbersList1 - numbersList2;

            //Assert
            Assert.AreEqual(expected, finalList.Count);
        }
        [TestMethod]
        public void AddTwoLists_WithContentsInterlaced()
        {
            //Arrange
            CustomList<int> numbersList1 = new CustomList<int>();
            numbersList1.AddItem(24);
            numbersList1.AddItem(30);
            CustomList<int> numbersList2 = new CustomList<int>();
            numbersList2.AddItem(2);
            numbersList2.AddItem(1);

            CustomList<int> finalList = new CustomList<int>();
            int expected = 4;

            //Act
            finalList.ZipTwoLists(numbersList1, numbersList2);

            //Assert
            Assert.AreEqual(expected, finalList.Count);
        }
    }
}
