namespace Computers.UI
{
    using System;
    using System.Collections.Generic;

    public class Computer
    {
        private readonly LaptopBattery battery;

        public IEnumerable<HardDriver> HardDrives { get; set; }

        public HardDriver VideoCard { get; set; }

        internal void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.Percentage));
        }

        public Cpu Cpu { get; set; }

        public Rammstein Ram { get; set; }

        public void Play(int guessNumber)
        {
            Cpu.rand(1, 10);
            var number = Ram.LoadValue();
            if (number + 1 != guessNumber + 1) VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            else VideoCard.Draw("You win!");
        }

        internal Computer(ComputerType type,
            Cpu cpu,
            Rammstein
            ram,
            IEnumerable<HardDriver> hardDrives,
            HardDriver videoCard,
            LaptopBattery battery)
        {
            Cpu = cpu;
            Ram = ram;
            HardDrives = hardDrives;
            VideoCard = videoCard;

            if (type != ComputerType.LAPTOP && type != ComputerType.PC) VideoCard.IsMonochrome = true;
            this.battery = battery;
        }

        internal void Process(int data)
        {
            Ram.SaveValue(data);
            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}
