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
            int input = 1;


            //Act
            customListint.AddToList(input);

            //Assert
            Assert.AreEqual(customListint[0], input);
        }

    }
}
