
using System.Collections;
using System.Collections.Generic;


namespace provaGen
{
    class MyGenList<T>: IEnumerable<T>
    {
        private T[] TArray { get; set; }
        public int Count { get; set; }

        public T this[int i]
        {
            get { return TArray[i]; }
            set { TArray[i] = value; }
        }

        public MyGenList()
        {
            Count = 0;
        }

        public void Add(T tObj)
        {
            Count++;
            if (TArray == null)
            {
                TArray = new T[Count];
                TArray[Count - 1] = tObj;
            }
            else
            {
                T[] temp = new T[Count];
                for (int i = 0; i < Count - 1; i++)
                {
                    temp[i] = TArray[i];
                }
                temp[Count - 1] = tObj;

                TArray = temp;
            }
        }

        public T Get(int index)
        {
            return TArray[index];
        }


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return Get(i);
            }
        }
    }
}
