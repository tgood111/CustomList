using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T>
    {


        // The array in the background
        private T[] _arr;

        public int Count { get; private set; }

        public CustomList()
        {
            _arr = new T[2];
        }

        // This is overloading +
        // var newList = a + b;
        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            // Add every element from b into a
            foreach (var element in b)
            {
                a.Add(element);
            }
            return a;
        }
        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            // Add every element from b into a
            foreach (var element in b)
            {
                a.RemoveValue(element);
            }
            return a;
        }


        // Overloads [] operator, so that we can assign and reference values
        public T this[int key]
        {
            // Reference
            get { return GetValue(key); }

            // Assign
            set { SetValue(key, value); }
        }

        // Let's us add an element to the List
        public void Add(T a)
        {
            if (_arr.Length <= Count)
            {
                // Temp is a temporary array to store the contents of my array before resizing.
                T[] temp = _arr;

                //Resize the array to (current count + 1) * 2
                _arr = new T[(Count + 1) * 2];

                // Copy the temp array contents into the new array
                // Not using foreach because the array is larger then the count
                for (int i = 0; i < temp.Length; ++i)
                {
                    _arr[i] = temp[i];
                }
            }

            // Add the new element to the next available position in the array
            _arr[Count] = a;

            //Update our count of items;
            Count++;
        }

        public void Add(CustomList<T> a)
        {
            // For every element in the list a, Add it to this list.
            for (int i = 0; i < a.Count; ++i)
            {
                Add(a[i]);
            }
        }

        public void Remove(int a)
        {
            // Out of range
            if (a >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            // Create temp array to work in
            T[] temp = new T[(Count - 1) * 2];
            for (int i = 0; i < Count; ++i)
            {
                // Skip the element at a
                if (i == a)
                {
                    continue;
                }
                // Copy ith in array element to ith element in temp
                if (i < a)
                {
                    temp[i] = _arr[i];
                }

                // Copy ith element in array to (i-1)th element in temp
                if (i > a)
                {
                    temp[i - 1] = _arr[i];
                }
            }
            _arr = temp;
            Count--;
        }

        public void RemoveValue(T a)
        {
            // Search for the element
            for (int i = 0; i < Count; ++i)
            {
                // Use a default comparer to determine if a is the same as the current index
                if (Comparer<T>.Default.Compare(a, _arr[i]) == 0)
                {
                    // Showing how comparer works for non-generic
                    // CustomList<int> a = new CustomList<int>();
                    // CustomList<int> b = new CustomList<int>();
                    // Comparer<CustomList<int>>.Default.Compare(a, b);
                    Remove(i);
                    return;
                }
            }
        }

        public T GetValue(int key)
        {
            return _arr[key];
        }

        public void SetValue(int key, T value)
        {
            _arr[key] = value;
        }

        public void Zip(CustomList<T> b)
        {
            //[1,3,5] + [2,4,6] = [1,3,5,2,4,6]
            Add(b);
            Array.Sort(_arr); // [1,2,3,4,5,6]
        }


        // Needed for IEnumberable so that this class can be Iterable.
        public IEnumerator<T> GetEnumerator()
        {
            // Yield each variable in _arr
            for (int i = 0; i < Count; ++i)
            {
                yield return _arr[i];
            }
        }

        public override string ToString()
        {
            string s = "[";

            //Add each element to the string
            for (int i = 0; i < Count; ++i)
            {
                s = s + _arr[i].ToString() + ",";
            }

            //Remove the last comma
            s = s.Substring(0, s.Length - 1);

            //Close the bracket
            s += "]";
            return s;
        }

        // Needed for IEnumberable so that this class can be Iterable.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}