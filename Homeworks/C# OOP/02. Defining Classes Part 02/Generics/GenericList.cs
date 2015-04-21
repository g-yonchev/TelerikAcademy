namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T>
        where T : IComparable
    {
        private T[] genericList;
        private int nextIndex;

        public GenericList(int capacity)
        {
            this.genericList = new T[capacity];
            this.nextIndex = 0;
        }

        public int Count
        {
            get
            {
                return this.nextIndex;
            }
        }

        public T Max()
        {
            T result = default(T);

            if (this.Count > 0)
            {
                result = this.genericList[0];

                for (int i = 1; i < this.nextIndex; i++)
                {
                    if (result.CompareTo(this.genericList[i]) < 0)
                    {
                        result = this.genericList[i];
                    }
                }
            }

            return result;
        }

        public T Min()
        {
            T result = default(T);

            if (this.Count > 0)
            {
                result = this.genericList[0];

                for (int i = 1; i < this.nextIndex; i++)
                {
                    if (result.CompareTo(this.genericList[i]) > 0)
                    {
                        result = this.genericList[i];
                    }
                }
            }

            return result;
        }

        public void InsertAtIndex(int index, T element)
        {
            if (index < 0 || index >= this.nextIndex)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (nextIndex == this.genericList.Length)
            {
                GrowList();
            }

            for (int i = this.nextIndex; i > index; i--)
            {
                this.genericList[i] = this.genericList[i - 1];
            }
            this.genericList[index] = element;
            nextIndex++;

        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.nextIndex; i++)
            {
                if (this.genericList[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            for (int i = 0; i < this.nextIndex; i++)
            {
                this.genericList[i] = default(T);
            }

            this.nextIndex = 0;
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= this.nextIndex)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = index; i < this.genericList.Length - 1; i++)
            {
                this.genericList[i] = this.genericList[i + 1];
            }
        }

        public void AddElement(T element)
        {
            if (this.nextIndex == this.genericList.Length)
            {
                GrowList();
            }
            this.genericList[nextIndex] = element;
            this.nextIndex++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.genericList.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.genericList[index];
            }
            private set { }
        }

        private void GrowList()
        {
            T[] newList = new T[this.genericList.Length * 2];

            for (int i = 0; i < this.genericList.Length; i++)
            {
                newList[i] = this.genericList[i];
            }

            this.genericList = newList;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i <= this.nextIndex - 1; i++)
            {
                result.Append(this.genericList[i] + " ");
            }
            return result.ToString();
        }
    }
}
