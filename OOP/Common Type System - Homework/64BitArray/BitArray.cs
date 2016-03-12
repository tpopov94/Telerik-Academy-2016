namespace _64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BitArray : IEnumerable<int>
    {
        private ulong number;

        // Constructors

        public BitArray(ulong number)
        {
            this.Number = number;
        }

        // Properties

        public ulong Number
        {
            get { return this.number; }
            set
            {
                if (value < 0 || value > ulong.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Number must be in the allowed ulong range");
                }
                else
                {
                    this.number = value;
                }
            }
        }

        public int[] ArrayOfBits
        {
            get { return this.Convert(this.Number); }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= ArrayOfBits.Count())
                {
                    throw new IndexOutOfRangeException("No such index");
                }
                else
                {

                    return ArrayOfBits[index];
                }
            }
        }

        // Methods

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.ArrayOfBits.Length; i++)
            {
                yield return this.ArrayOfBits[i];
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is BitArray)
            {
                for (int i = 0; i < this.ArrayOfBits.Length; i++)
                {
                    if (this.ArrayOfBits[i] != (obj as BitArray).ArrayOfBits[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            if (obj is string)
            {
                var padded = (obj as string).PadLeft(64, '0');

                for (int i = 0; i < padded.Length; i++)
                {
                    if (int.Parse(padded[i].ToString()) != this.ArrayOfBits[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode() * 12 ^ this.ArrayOfBits[5].GetHashCode() ^
            this.ArrayOfBits[4].GetHashCode();
        }

        public static bool operator ==(BitArray first, BitArray second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray first, BitArray second)
        {
            return !first.Equals(second);
        }

        private int[] Convert(ulong value)
        {
            int[] result = new int[64];
            int counter = 63;

            do
            {
                result[counter] = (int)value % 2;
                value /= 2;
                counter--;
            } while (value > 0);

            if (counter > 0)
            {
                for (int i = counter; i >= 0; i--)
                {
                    result[i] = 0;
                }
            }
            return result;
        }
    }
}
