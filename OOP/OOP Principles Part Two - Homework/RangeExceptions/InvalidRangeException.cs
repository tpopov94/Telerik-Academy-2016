namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;
        
        public InvalidRangeException(string message, T start, T end, Exception inner)
            : base(message, inner)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : base(message)
        {

        }

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
    }
}
