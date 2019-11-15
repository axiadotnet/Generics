using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace provaGen
{
    class MyList: IEnumerable
    {
        private object[] ObjectArray { get; set; }
        public int Count { get; set; }

        public object this[int i]
        {
            get { return ObjectArray[i]; } 
            set { ObjectArray[i] = value; } 
        }

        public MyList()
        {
            Count = 0;
        }

        public void Add(object obj)
        {
            Count++;
            if (ObjectArray==null)
            {
                ObjectArray = new object[Count];
                ObjectArray[Count - 1] = obj;
            }
            else
            {
                object[] temp = new object[Count];
                for (int i = 0; i < Count-1; i++)
                {
                    temp[i] = ObjectArray[i];
                }
                temp[Count - 1] = obj;

                ObjectArray = temp;
            }
        }

        public object Get(int index)
        {
            return ObjectArray[index];
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return ObjectArray[i];
            }
        }
    }
}
