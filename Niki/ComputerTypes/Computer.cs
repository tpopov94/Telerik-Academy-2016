namespace Computers.UI
{
    using System.Collections.Generic;

    public abstract class Computer
    {
        internal Computer(Cpu cpu, Ram ram, IEnumerable<HardDriver> hardDrives, HardDriver videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
        }

        public IEnumerable<HardDriver> HardDrives { get; set; }

        public HardDriver VideoCard { get; set; }

        public Cpu Cpu { get; set; }

        public Ram Ram { get; set; }
    }
}
