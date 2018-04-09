using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        // Member Variables
        T[] testList;
        int count;
        int capacity;

        //Constructor
        public CustomList()
        {
            this.capacity = 1;
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

        public void AddToList(T input)
        {
            testList[count] = input;
            count++;
        }


    }
}
