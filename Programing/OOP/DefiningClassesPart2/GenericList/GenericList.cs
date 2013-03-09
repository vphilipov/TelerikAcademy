using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    public class GenericList<T> : IEnumerable<T>
    {
        #region Fieds
        private const int DefaultCapcacity = 4;
        private T[] list;
        private uint capacity;
        private int count;
        #endregion

        #region Constructors
        public GenericList()
            : this(DefaultCapcacity)
        {
        }

        public GenericList(uint capacity)
        {
            this.Capacity = capacity;
            this.list = new T[capacity];
        }

        public GenericList(T[] array)
        {
            this.list = new T[array.Length];
            this.Capacity = (uint)array.Length;
            this.Count = array.Length;
            Array.Copy(array, list, array.Length);
        }
        #endregion

        #region Properties
        public uint Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public T this[int index]
        {
            get
            {
                IndexCheck(index);
                return this.list[index];
            }
            set
            {
                IndexCheck(index);
                this.list[index] = value;
            }
        }

        #endregion

        #region Private Methods
        private void Resize()
        {
            uint newCapacity = this.capacity * 2;
            T[] newList = new T[newCapacity];
            Array.Copy(this.list, newList, this.capacity);
            this.capacity = newCapacity;
            this.list = newList;
        }

        private void IndexCheck(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
        }
        #endregion

        #region PublicMethods
        public void Insert(T newElement, int index)
        {
            if (this.capacity == this.count)
            {
                Resize();
            }
            for (int i = count; i > index; i--)
            {
                this.list[i] = this.list[i - 1];
            }
            this.list[index] = newElement;
            count++;
        }

        public void Add(T newElement)
        {
            Insert(newElement, this.count);
        }

        public void Remove(int index)
        {
            for (int i = index; i < this.count; i++)
            {
                this.list[i] = this.list[i + 1];
            }
            this.list[count - 1] = default(T);
            count--;
        }

        public void Clear()
        {
            this.list = new T[DefaultCapcacity];
        }

        public int FindElement(T value)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.list[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public T Min()
        {
            if (this.list[0] is IComparable<T>)
            {
                T min = this.list[0];

                for (int index = 0; index < this.count; index++)
                {
                    if ((min as IComparable<T>).CompareTo(this.list[index]) > 0)
                    {
                        min = this.list[index];
                    }
                }

                return min;
            }
            else
            {
                throw new  TypeAccessException("This data type cannot be compared!");
            }
        }

        public T Max()
        {
            if (this.list[0] is IComparable<T>)
            {
                T max = this.list[0];

                for (int index = 0; index < this.count; index++)
                {
                    if ((max as IComparable<T>).CompareTo(this.list[index]) < 0)
                    {
                        max = this.list[index];
                    }
                }

                return max;
            }
            else
            {
                throw new TypeAccessException("This data type cannot be compared!");
            }
        }

        public override string ToString()
        {
            StringBuilder bobTheStringBuilder = new StringBuilder();

            for (int index = 0, length = this.count - 1; index < length; index++)
            {
                bobTheStringBuilder.AppendFormat("{0}, ", this.list[index]);
            }
            bobTheStringBuilder.Append(this.list[this.count - 1]);

            return bobTheStringBuilder.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in this.list)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
