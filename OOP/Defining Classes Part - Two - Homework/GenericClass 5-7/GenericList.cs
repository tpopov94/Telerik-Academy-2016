namespace GenericClass_5_7
{
    using System;


    public class GenericList<T> where T: IComparable<T>// Tasks 5 - 7
    {
        private const int InitialCapacity = 5;
        private int count;
        private int capacity;

        private T[] elements;

        //constructors

        public GenericList()
        {
            this.Capacity = InitialCapacity;
            this.elements = new T[InitialCapacity];
        }

        // Properties

        public int Count { get; set; }

        public int Capacity { get; set; }

        // Methods

        public void Add(T element)
        {
            // Checking for capacity   // Task 6 
            if (this.Count == this.Capacity)
            {
                this.DoubleSize();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public void DoubleSize()
        {
            var oldElements = this.elements;
            this.Capacity *= 2;
            this.elements = new T[Capacity];
            Array.Copy(oldElements, this.elements, this.Count);
        }  // Task 6 

        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < this.Count; i++)
            {
                result += this.elements[i];
                if (i < this.Count - 1)
                {
                    result += ", ";
                }
            }
            return result;
        }

        public void Clear()
        {
            this.elements = new T[InitialCapacity];
            this.Capacity = InitialCapacity;
            this.Count = 0;
        }

        public void RemoveAtIndex(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", index));
            }

            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.Count--;
        }

        public void AddAtIndex(int index, T newElement)
        {
            if (index >= this.Capacity || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", index));
            }

            var temp = new GenericList<T>();

            for (int i = index; i < this.Count; i++)
            {
                temp.Add(this.elements[i]);
            }

            this.elements[index] = newElement;

            for (int i = 0, j = index + 1; i <= temp.Count; i++, j++)
            {
                this.elements[j] = temp.elements[i];
            }
            this.Count++;
        }

        public T Min() // Task 7
        {
            if ((this.Count) < 0 )
            {
                throw new ArgumentException("There are no elements in this list");
            }
            T min = this.elements[0];

            foreach (T item in this.elements)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public T Max()  // Task 7
        {
            if ((this.Count) < 0)
            {
                throw new ArgumentException("There are no elements in this list");
            }
            T max = this.elements[0];

            foreach (T item in this.elements)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
