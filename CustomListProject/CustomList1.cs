using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        // Member Variables
        T[] testList;
        int count;
        int capacity;
        
        //Constructor
        public CustomList()
        {
            this.capacity = 5;
            this.testList = new T[capacity];
        }

        //Methods

        public T this[int i]
        {
            get
            {
                return testList[i];
            }
            set 
            {
                testList[i] = value;
            }
        }


        public int ListCount
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }


        public void Add(T input)
        {
            CheckArraySize();
            testList[count] = input;
            count++;
        }


        public void ResizeArray()
        {
            capacity = (capacity * 2);
            T[] tempArray = new T[capacity];
            for (int i = 0; i <=count; i++)
            {
                tempArray[i] = testList[i];
            }
            testList = tempArray;
        }

        
        public void CheckArraySize()
        {
            if(capacity <= (count * 2))
            {
                ResizeArray();
            }
        }


        public void RemoveItemFromList(T input)
        {
            for (int i =0; i <= count; i++)
            {
                if (testList[i].Equals(input))
                {
                    while (i < count)
                    {
                        testList[i] = testList[i + 1];
                        i++;
                    }
                    count--;
                    break;
                }
                
            }
        }


        public override string ToString()
        {
            string newString = "";
            for (int i = 0; i < count; i++)
            {
                newString += testList[i].ToString();
            }
            return newString;
        }


        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> testList = new CustomList<T>();


            for (int i = 0; i < list1.ListCount; i++)
            {
                testList.Add(list1[i]);
            }
            for (int i = 0; i < list2.ListCount; i++)
            {
                testList.Add(list2[i]);
            }
            return testList;
        }


        public static CustomList<T> operator - (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> testList = new CustomList<T>();


        }




        ////not being used
        //public void Remove(T input)
        //{

        //    RemoveItemFromList(input);
        //    ItemToRemove();

        //}

        ////not being used
        //public void ItemToRemove()
        //{
        //    T[] TempArray = new T[capacity];
        //    for (int i = 0; i <= (count - 1); i++)
        //    {
        //        TempArray[i] = testList[i];
        //    }
        //    testList = TempArray;
        //}









        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return testList[i];
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        


    }
}
