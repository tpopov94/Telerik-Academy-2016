namespace Computers.UI
{
    using System;
    using System.Collections.Generic;

    using ComputerTypes;

    public class HpComputerFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            var laptopVideo = new VideoCard() { IsMonochrome = false };
            var laptopRam = new Ram(4);

            var laptop = new Laptop(new Cpu(8 / 4, 64, laptopRam, laptopVideo), laptopRam, new[] { new HardDrive(500, false, 0) }, laptopVideo, new System.LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(2);
            var videoCard = new VideoCard() { IsMonochrome = false };

            var pc = new PersonalComputer(new Cpu(8 / 4, 32, ram, videoCard), ram, new[] { new HardDrive(500, false, 0) }, videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            var serverRam = new Ram(32);
            var serverVideo = new VideoCard();

            var server = new Server(new Cpu(8 / 2, 32, serverRam, serverVideo), serverRam, new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(1000, false, 0), new HardDrive(1000, false, 0) }) }, serverVideo);

            return server;
        }
    }
}
