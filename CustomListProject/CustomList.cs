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
            ResizeArray();
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

        


        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)testList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)testList).GetEnumerator();
        }

        


    }
}
