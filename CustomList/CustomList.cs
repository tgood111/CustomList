using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomList
{
    public class CustomList<T>
    {   //private T[] array;
        //public int Count {get; private set;}
        //public static CustomList <T> operator +(CustomList<T> a, CustomList<T> b)
        //{
        //null;
        //}
        // The array in the background
        private T[] array;

        public int Count { get; private set; }

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            return null;
        }

        //Overloads [] operator, so that we can assign and reference values
        public T this[int key]
        {
            // Reference
            get
            {
                return GetValue(key);
            }

            // Assign
            set
            {
                SetValue(key, value);
            }
        }

        // Let's us add an element to the List
        public void Add(T a)
        {
            throw new NotImplementedException();
        }

        public void Add(CustomList<T> a)
        {
            throw new NotImplementedException();
        }

        public void Remove(int a)
        {
            throw new NotImplementedException();
        }

        public T GetValue(int key)
        {
            return array[key];
        }

        public void SetValue(int key, T value)
        {
            array[key] = value;
        }

        public void Zip(CustomList<T> b)
        {
            throw new NotImplementedException();
        }
    }
}