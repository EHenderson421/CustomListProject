using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace Test.CustomList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddIntToList_True()
        {

            //Arrange
            CustomList<int> customListint = new CustomList<int>();
            int input = 4;
            int expected = 4;

            //Act
            customListint.Add(input);

            //Assert
            Assert.AreEqual(expected, customListint[0]);
        }


        [TestMethod]
        public void Test_CountOfItemsInList_TotalOfFive()
        {

            //Arrange
            CustomList<int> customListCount = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 5;

            //Act
            int numberOfItems = customListCount.ListCount;

            //Assert
            Assert.AreEqual(expected, numberOfItems);
        }


        [TestMethod]
        public void Test_PositionInList_Three()
        {
            //Arrange
            CustomList<int> customListPosition = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 3;
            
            //Act
            int itemPosition = customListPosition[2];

            //Assert
            Assert.AreEqual(expected, itemPosition);
        }


        [TestMethod]
        public void Test_ItemAddedToEndOfList_TEN()
        {
            //Arrange
            CustomList<int> customListPosition = new CustomList<int>() { 1, 2, 3, 4 };
            int inputPosition5 = 10;
            int expected = 10;
            //Act
            customListPosition.Add(inputPosition5);
            
            //Assert
            Assert.AreEqual(expected, customListPosition[4]);
        }


        [TestMethod]
        public void Test_SizeOfListLargerThenCapacity()
        {
            //Arrange
            CustomList<int> customListSize = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int expected = 15;

            //Act
            int numberOfItems = customListSize.ListCount;

            //Assert
            Assert.AreEqual(expected, numberOfItems);

        }


        [TestMethod]
        public void Test_RemoveItemFromArray()
        {
            //Arrange
            CustomList<int> customListRemove = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int input = 3;
            int expected = 4;
            //Act
            customListRemove.Remove(input);

            //Assert
            Assert.AreEqual(expected, customListRemove[2]);
        }

        [TestMethod]
        public void Test_SizeOfListAfterRemovingItem()
        {
            //Arrange
            CustomList<int> customListRemove = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int input = 3;
            int expected = 4;

            //Act
            customListRemove.Remove(input);
            int numberOfItems = customListRemove.ListCount;

            //Assert
            Assert.AreEqual(expected, numberOfItems);

        }





    }
}
