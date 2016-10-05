namespace Computers.UI.ComputerTypes
{
    using System.Collections.Generic;

    public class Server : Computer
    {
        public Server(Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.VideoCard.IsMonochrome = true;
        }

        public void Process(int data)
        {
            this.Ram.SaveValue(data);

            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}
