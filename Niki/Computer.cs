namespace Computers.UI
{
    using System.Collections.Generic;

    public class Computer
    {
        private readonly LaptopBattery battery;

        internal Computer(ComputerType type, Cpu cpu, Ram ram, IEnumerable<HardDriver> hardDrives, HardDriver videoCard, LaptopBattery battery)
        {
            Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;

            if (type != ComputerType.LAPTOP && type != ComputerType.PC)
            {
                this.VideoCard.IsMonochrome = true;
            }

            this.battery = battery;
        }

        public IEnumerable<HardDriver> HardDrives { get; set; }

        public HardDriver VideoCard { get; set; }

        public Cpu Cpu { get; set; }

        public Ram Ram { get; set; }

        public void Play(int guessNumber)
        {
            Cpu.Rand(1, 10);

            var number = this.Ram.LoadValue();

            if (number + 1 != guessNumber + 1)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }

        internal void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.Percentage));
        }

        internal void Process(int data)
        {
            this.Ram.SaveValue(data);

            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}
