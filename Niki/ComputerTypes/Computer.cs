namespace Computers.UI
{
    using System.Collections.Generic;

    public abstract class Computer
    {
        internal Computer(Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
        }

        public IEnumerable<HardDrive> HardDrives { get; set; }

        public VideoCard VideoCard { get; set; }

        public Cpu Cpu { get; set; }

        public Ram Ram { get; set; }
    }
}
