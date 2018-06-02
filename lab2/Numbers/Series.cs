using System;
using System.Collections.Generic;

namespace Numbers
{
    class Series<T> where T : Number
    {
        private List<T> numbers;

        public int Count
        {
            get
            {
                return numbers.Count;
            }
        }

        public Series()
        {
            numbers = new List<T>();
        } 
        
        public void Add(T element)
        {
            numbers.Add(element);
        }

        public void Delete(int index)
        {
            if (index > 0 && index < numbers.Count)
            {
                numbers.RemoveAt(index);
            }
            else
            {
                throw new Exceptions.MyIndexOutOfRangeException("Invalid index for deleting!");
            }
        }

        public Series<T> DeepCopy()
        {
            Series<T> clone = new Series<T>();

            foreach(var item in numbers)
            {
                clone.Add((T)item.Clone());
            }

            return clone;
        }
        
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < numbers.Count)
                {
                    return numbers[index];
                }
                else
                {
                    throw new Exceptions.MyIndexOutOfRangeException("Invalid index for indexator");
                }
            }
            set
            {
                if (index > 0 && index < numbers.Count)
                {
                    if (numbers[index].GetType() == value.GetType())
                    {
                        numbers[index] = value;
                    }
                    else
                    {
                        throw new Exceptions.MyInvalidCastException("Inccorect type to Series!");
                    }
                }
                else
                {
                    throw new Exceptions.MyIndexOutOfRangeException("Invalid index for indexator");
                }
            }
        }           

        public void ShowInfo()
        {
            int counter = 1;
            foreach(var item in numbers)
            {
                Console.WriteLine($" {counter}\t-\t{item.ToString()}\t({item.GetType()})");
                counter++;
            }
        }
    }
}
