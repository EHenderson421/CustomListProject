using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace Test.CustomList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddIntToList()
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
        public void Test_CountOfItemsInList()
        {

            //Arrange
            CustomList<int> customListCount = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 5;
            int numberOfItems;
            //Act
            numberOfItems = customListCount.ListCount;

            //Assert
            Assert.AreEqual(expected, numberOfItems);
        }


        [TestMethod]
        public void Test_PositionInList()
        {
            //Arrange
            CustomList<int> customListPosition = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 3;
            int itemPosition;
            //Act
            itemPosition = customListPosition[2];

            //Assert
            Assert.AreEqual(expected, itemPosition);
        }


        [TestMethod]
        public void Test_ItemAddedToEndOfList()
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
        public void Test_RemoveItemFromList()
        {
            //Arrange
            CustomList<int> customListRemove = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int input = 3;
            int expected = 4;
            
            //Act
            customListRemove.RemoveItemFromList(input);

            //Assert
            Assert.AreEqual(expected, customListRemove[2]);
        }


        [TestMethod]
        public void Test_SizeOfList()
        {
            //Arrange
            CustomList<int> customListRemove = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 5;
            int numberOfItems;
            
            //Act
            numberOfItems = customListRemove.ListCount;

            //Assert
            Assert.AreEqual(expected, numberOfItems);
        }


        [TestMethod]
        public void Test_SizeOfListAfterRemovingItem()
        {
            //Arrange
            CustomList<int> customListRemove = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int input = 3;
            int expected = 4;
            int numberOfItems;
            
            //Act
            customListRemove.RemoveItemFromList(input);
            numberOfItems = customListRemove.ListCount;

            //Assert
            Assert.AreEqual(expected, numberOfItems);

        }


        [TestMethod]
        public void Test_ListToString()
        {
            //Arrange
            CustomList<double> listToString1 = new CustomList<double>() { 1, 2, 3, 4, 5, };
            CustomList<CustomList<double>> listToString2 = new CustomList<CustomList<double>>();
            string expected = "12345";
            string testString;

            //Act
            testString = listToString1.ToString();

            //Assert
            Assert.AreEqual(expected, testString);

        }


        [TestMethod]
        public void Test_AddOverloadInt()
        {
            //Arrange
            CustomList<int> overloadList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> overloadList2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> overloadList3 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            //Act
            overloadList3 = overloadList1 + overloadList2;

            //Assert
            Assert.AreEqual(expectedList[0], overloadList3[0]);       
        }


        [TestMethod]
        public void Test_AddOverloadLastIndex()
        {
            //Arrange
            CustomList<int> overloadList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> overloadList2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> overloadList3 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };

            //Act
            overloadList3 = overloadList1 + overloadList2;

            //Assert
            Assert.AreEqual(expectedList[5], overloadList2[2]);
        }


        [TestMethod]
        public void Test_SizeOfArrayAfterOverload()
        {
            //Arrange
            CustomList<int> overloadList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> overloadList2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> overloadList3 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            int expected = 6;
            int numberOfItems;

            //Act
            overloadList3 = overloadList1 + overloadList2;
            numberOfItems = overloadList3.ListCount;

            //Assert
            Assert.AreEqual(expected, numberOfItems);


        }
    }
}
////Arrange
//CustomList<int> customListint = new CustomList<int>();
//int input = 4;
//int expected = 4;

////Act
//customListint.Add(input);

//            //Assert
//            Assert.AreEqual(expected, customListint[0]);
//        }