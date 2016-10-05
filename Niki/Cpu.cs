namespace Computers.UI
{
    using System;

    public class Cpu
    {
        public static readonly Random Random = new Random();

        private readonly byte numberOfBits;

        private readonly Ram ram;

        private readonly VideoCard videoCard = new VideoCard();

        internal Cpu(byte numberOfCores, byte numberOfBits, Ram ram, VideoCard videoCard)
        {
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
        }

        public byte NumberOfCores { get; set; }

        public void SquareNumber()
        {
            if (this.numberOfBits == 32)
            {
                this.SquareNumber32();
            }

            if (this.numberOfBits == 64)
            {
                this.SquareNumber64();
            }
        }

        public void SquareNumber32()
        {
            var data = this.ram.LoadValue();

            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 500)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;

                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        public void SquareNumber64()
        {
            var data = this.ram.LoadValue();

            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 1000)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;

                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        internal void Rand(int a, int b)
        {
            int randomNumber;

            do
            {
                randomNumber = Random.Next(0, 1000);
            }
            while (!(randomNumber >= a && randomNumber <= b));

            this.ram.SaveValue(randomNumber);
        }
    }
}
