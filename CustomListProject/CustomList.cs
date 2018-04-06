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


        //Constructor
        public CustomList()
        {

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

        }


    }
}
